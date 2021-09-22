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
        }

        int iterations = 0;
        double callTime = 0, averageCallTime = 0;
        String token, chatId;


        async private void confirm(object sender, EventArgs e)
        {
            operationProgress.Value = 0;
            token = tokenField.Text;
            chatId = chatIdField.Text;
            var url = "https://discordapp.com/api/users/@me/channels";
            JArray channels;
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Headers["Authorization"] = token;
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            operationProgress.Value = 15;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            using (JsonTextReader reader = new JsonTextReader(streamReader))

                channels = (JArray)JToken.ReadFrom(reader);

            Dictionary<string, string> channelDictionary = new Dictionary<string, string>();
            operationProgress.Value = 30;
            foreach (var channelX in channels)
            {
                if (channelX["type"].ToString() == "1")
                {
                    channelDictionary.Add(channelX["id"].ToString(), channelX["recipients"][0]["username"].ToString());
                }
                else
                {
                    String groupName = ">>";

                    foreach (var recipient in channelX["recipients"])
                    {
                        groupName += $"{recipient["username"]}, ";
                    }

                    groupName = groupName.Substring(0, groupName.Length - 2);

                    channelDictionary.Add(channelX["id"].ToString(), channelX["name"].ToString());
                }
            }
            operationProgress.Value = 50;
            String arguments = $"DiscordChatExporter.Cli.dll export -t {token} -c {chatId} -f Json -o messages.json";
            String workingDir = Directory.GetCurrentDirectory();

            var stdOut = Console.OpenStandardOutput();
            var stdErr = Console.OpenStandardError();

            var result = await(Cli.Wrap($"dotnet")| (stdOut, stdErr))
                .WithArguments(arguments)
                .WithWorkingDirectory(workingDir)
                .WithValidation(CommandResultValidation.None)
                .ExecuteBufferedAsync();

            operationProgress.Value = 60;

            using (StreamReader file = File.OpenText($"messages.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o = (JObject)JToken.ReadFrom(reader);

                foreach (var message in o["messages"])
                {
                    if (message["type"].ToString() == "Call")
                    {
                        try
                        {
                            if (message["timestamp"].ToString() != "null" && message["callEndedTimestamp"].ToString() != null)
                            {
                                // Getting both timestamps of call beginning and call end
                                String timestamp = message["timestamp"].ToString();
                                String timestampEnd = message["callEndedTimestamp"].ToString();

                                // Converting timestamps to DateTime
                                DateTime start = DateTime.Parse(timestamp);
                                DateTime end = DateTime.Parse(timestampEnd);

                                // Calculating the timespan between call start and end and saving it as a timespan object
                                TimeSpan duration = end - start;

                                averageCallTime += duration.TotalSeconds;
                                iterations++;
                                // Getting the total duration in seconds and adding it to the global total call time
                                callTime += duration.TotalSeconds;
                            }
                        }
                        catch
                        {
                            // This code is unreachable but it's here for the memes https://www.youtube.com/watch?v=2gQl3JDz0dM
                        }
                    }
                }
            }
            operationProgress.Value = 90;
            var days = (int)callTime / 60 / 60 / 24;
            var hours = (int)callTime / 60 / 60 % 24;
            var minutes = (int)callTime / 60 % 60;
            var seconds = (int)callTime % 60;

            averageCallTime = averageCallTime / iterations;

            var avgHours = (int)averageCallTime / 60 / 60 % 24;
            var avgMinutes = (int)averageCallTime / 60 % 60;
            var avgSeconds = (int)averageCallTime % 60;

            totalCallTime.Text = $"{days} days {hours} hours {minutes} minutes {seconds} seconds";
            avgCallTime.Text = $"{avgHours} hours {avgMinutes} minutes {avgSeconds} seconds";

            operationProgress.Value = 100;

            callTime = 0;
        }

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

        private void msUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
