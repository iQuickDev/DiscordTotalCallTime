using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net;
using CliWrap;
using CliWrap.Buffered;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Text;

namespace DiscordTotalCallTime
{
    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll")]
        internal static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public MainForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            dragPanel.MouseDown += msDwn;
            dragPanel.MouseMove += msMv;
            dragPanel.MouseUp += msUp;
            closeBtn.Click += close;
            confirmBtn.Click += confirm;
            importJSON.Click += ImportJson;
            tokenField.TextChanged += UpdateChannelIDsCombo;
            enterIDManuallyCheckBox.CheckedChanged += enterIDManuallyCheckBoxCheckedChange;
        }

        protected override void OnLoad(EventArgs e) {
            String[] placeholder = new String[] { "DM or Group Chat" };
            chatIDCombo.DataSource = placeholder;
        }

        String token, chatId;

        // a lot of this code has been written by https://github.com/randomcmd, sincerely, thank you.

        private void ImportJson(object sender, EventArgs e)
        {
            ImportJsonAsync();
        }

        private async Task ImportJsonAsync()
        {
            jsonFileBrowser.ShowDialog();
            double[] callTimeValues = await DiscordTotalCallTime.ImportJSonFromFile(jsonFileBrowser.FileName);
            if (callTimeValues != null)
            {
                operationProgress.Value = 90;
                UpdateGUI(callTimeValues[0], callTimeValues[1]);
            }
            else
            {
                MessageBox.Show("The selected file cannot be read");
            }
        }

        async private void confirm(object sender, EventArgs e)
        {
            operationProgress.Value = 0;
            confirmBtn.Enabled = false;
            await DiscordTotalCallTime.ExportDiscordChatFromID(chatIdField.Text, tokenField.Text, showOutputCheckBox.Checked, operationProgress);
            confirmBtn.Enabled = true;
            var fileName = jsonFileBrowser.FileName != "" ? jsonFileBrowser.FileName : "messages.json";

            double[] callTimeValues = await DiscordTotalCallTime.ImportJSonFromFile(fileName);
            
            if (callTimeValues != null)
            {
                operationProgress.Value = 90;
                UpdateGUI(callTimeValues[0], callTimeValues[1]);
            }
            else
            {
                MessageBox.Show("Error exporting file from ID");
            }

            operationProgress.Value = 90;

            //Deleting file so nobody can snoop into the messages
            if(!keepJSONCheckBox.Checked) File.Delete(fileName);
        }

        private void UpdateGUI(double callTime, double iterations)
        {
            var days = (int)callTime / 60 / 60 / 24;
            var hours = (int)callTime / 60 / 60 % 24;
            var minutes = (int)callTime / 60 % 60;
            var seconds = (int)callTime % 60;

            var averageCallTime = callTime / iterations;

            var avgHours = (int)averageCallTime / 60 / 60 % 24;
            var avgMinutes = (int)averageCallTime / 60 % 60;
            var avgSeconds = (int)averageCallTime % 60;

            totalCallTime.Text = $"{days} days {hours} hours {minutes} minutes {seconds} seconds";
            avgCallTime.Text = $"{avgHours} hours {avgMinutes} minutes {avgSeconds} seconds";

            operationProgress.Value = 100;

            callTime = 0;
            averageCallTime = 0;
            iterations = 0;
        }

        ArrayList IDs;
        ArrayList Names;
        private async void UpdateChannelIDsCombo(object sender, EventArgs e)
        {
            if (tokenField.Text.StartsWith("\"")) { 
                StringBuilder stringBuilder = new StringBuilder(tokenField.Text);
                stringBuilder.Remove(0, 1);
                tokenField.Text = stringBuilder.ToString();
            }

            if (tokenField.Text.EndsWith("\""))
            {
                StringBuilder stringBuilder = new StringBuilder(tokenField.Text);
                stringBuilder.Remove(stringBuilder.Length-1, 1);
                tokenField.Text = stringBuilder.ToString();
            }

            ArrayList[] IDsandNames = await DiscordTotalCallTime.GetChannelIDs(tokenField.Text);
            if(IDsandNames != null) { 
                IDs = IDsandNames[0];
                Names = IDsandNames[1];

                chatIDCombo.DataSource = Names;
                chatIDCombo.ForeColor = Color.White;
            }
        }

        #region window
        private void close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void msDwn(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void msMv(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void chatIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(IDs != null) chatIdField.Text = IDs[chatIDCombo.SelectedIndex].ToString();
        }

        private void enterIDManuallyCheckBoxCheckedChange(object sender, EventArgs e)
        {
            var isChecked = enterIDManuallyCheckBox.Checked;
            chatIDCombo.Visible = !isChecked;
            chatIdField.Visible = isChecked;
        }

        private void msUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion window
    }
}
