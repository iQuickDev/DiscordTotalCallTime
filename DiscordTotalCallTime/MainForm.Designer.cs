
namespace DiscordTotalCallTime
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.softwareIcon = new System.Windows.Forms.PictureBox();
            this.closeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tokenField = new Guna.UI2.WinForms.Guna2TextBox();
            this.chatIdField = new Guna.UI2.WinForms.Guna2TextBox();
            this.confirmBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.totalCallTimeContainer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.totalCallTime = new System.Windows.Forms.Label();
            this.avgCallTimeContainer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.avgCallTime = new System.Windows.Forms.Label();
            this.startedCallsContainer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.enterIDManuallyCheckBox = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.showOutputCheckBox = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.keepJSONCheckBox = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.startedCalls = new Guna.UI2.WinForms.Guna2DataGridView();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.importJSON = new Guna.UI2.WinForms.Guna2Button();
            this.trustLabel = new System.Windows.Forms.Label();
            this.jsonFileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.chatIDCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softwareIcon)).BeginInit();
            this.totalCallTimeContainer.SuspendLayout();
            this.avgCallTimeContainer.SuspendLayout();
            this.startedCallsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startedCalls)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.dragPanel.Controls.Add(this.softwareIcon);
            this.dragPanel.Controls.Add(this.closeBtn);
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(600, 30);
            this.dragPanel.TabIndex = 0;
            // 
            // softwareIcon
            // 
            this.softwareIcon.Image = ((System.Drawing.Image)(resources.GetObject("softwareIcon.Image")));
            this.softwareIcon.Location = new System.Drawing.Point(285, 0);
            this.softwareIcon.Name = "softwareIcon";
            this.softwareIcon.Size = new System.Drawing.Size(30, 30);
            this.softwareIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.softwareIcon.TabIndex = 10;
            this.softwareIcon.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.CheckedState.Parent = this.closeBtn;
            this.closeBtn.CustomImages.Parent = this.closeBtn;
            this.closeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeBtn.DisabledState.Parent = this.closeBtn;
            this.closeBtn.FillColor = System.Drawing.Color.Red;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.HoverState.Parent = this.closeBtn;
            this.closeBtn.Location = new System.Drawing.Point(574, 7);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeBtn.ShadowDecoration.Parent = this.closeBtn;
            this.closeBtn.Size = new System.Drawing.Size(15, 15);
            this.closeBtn.TabIndex = 1;
            // 
            // tokenField
            // 
            this.tokenField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.tokenField.BorderRadius = 5;
            this.tokenField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tokenField.DefaultText = "";
            this.tokenField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tokenField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tokenField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tokenField.DisabledState.Parent = this.tokenField;
            this.tokenField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tokenField.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.tokenField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tokenField.FocusedState.Parent = this.tokenField;
            this.tokenField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tokenField.ForeColor = System.Drawing.Color.White;
            this.tokenField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tokenField.HoverState.Parent = this.tokenField;
            this.tokenField.Location = new System.Drawing.Point(13, 53);
            this.tokenField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tokenField.Name = "tokenField";
            this.tokenField.PasswordChar = '\0';
            this.tokenField.PlaceholderText = "Discord Token";
            this.tokenField.SelectedText = "";
            this.tokenField.ShadowDecoration.Parent = this.tokenField;
            this.tokenField.Size = new System.Drawing.Size(243, 40);
            this.tokenField.TabIndex = 1;
            // 
            // chatIdField
            // 
            this.chatIdField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.chatIdField.BorderRadius = 5;
            this.chatIdField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chatIdField.DefaultText = "";
            this.chatIdField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.chatIdField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.chatIdField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chatIdField.DisabledState.Parent = this.chatIdField;
            this.chatIdField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chatIdField.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.chatIdField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chatIdField.FocusedState.Parent = this.chatIdField;
            this.chatIdField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatIdField.ForeColor = System.Drawing.Color.White;
            this.chatIdField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chatIdField.HoverState.Parent = this.chatIdField;
            this.chatIdField.Location = new System.Drawing.Point(343, 53);
            this.chatIdField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chatIdField.Name = "chatIdField";
            this.chatIdField.PasswordChar = '\0';
            this.chatIdField.PlaceholderText = "Chat ID";
            this.chatIdField.SelectedText = "";
            this.chatIdField.ShadowDecoration.Parent = this.chatIdField;
            this.chatIdField.Size = new System.Drawing.Size(243, 40);
            this.chatIdField.TabIndex = 2;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.BorderColor = System.Drawing.Color.Transparent;
            this.confirmBtn.CheckedState.Parent = this.confirmBtn;
            this.confirmBtn.CustomImages.Parent = this.confirmBtn;
            this.confirmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmBtn.DisabledState.Parent = this.confirmBtn;
            this.confirmBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(82)))));
            this.confirmBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.HoverState.Parent = this.confirmBtn;
            this.confirmBtn.Image = ((System.Drawing.Image)(resources.GetObject("confirmBtn.Image")));
            this.confirmBtn.ImageSize = new System.Drawing.Size(28, 25);
            this.confirmBtn.Location = new System.Drawing.Point(282, 53);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.confirmBtn.ShadowDecoration.Parent = this.confirmBtn;
            this.confirmBtn.Size = new System.Drawing.Size(40, 40);
            this.confirmBtn.TabIndex = 3;
            this.confirmBtn.UseTransparentBackground = true;
            // 
            // totalCallTimeContainer
            // 
            this.totalCallTimeContainer.BackColor = System.Drawing.Color.Transparent;
            this.totalCallTimeContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.totalCallTimeContainer.BorderRadius = 5;
            this.totalCallTimeContainer.Controls.Add(this.totalCallTime);
            this.totalCallTimeContainer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.totalCallTimeContainer.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.totalCallTimeContainer.FillColor = System.Drawing.Color.Transparent;
            this.totalCallTimeContainer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.totalCallTimeContainer.ForeColor = System.Drawing.Color.White;
            this.totalCallTimeContainer.Location = new System.Drawing.Point(13, 118);
            this.totalCallTimeContainer.Name = "totalCallTimeContainer";
            this.totalCallTimeContainer.ShadowDecoration.Parent = this.totalCallTimeContainer;
            this.totalCallTimeContainer.Size = new System.Drawing.Size(376, 79);
            this.totalCallTimeContainer.TabIndex = 4;
            this.totalCallTimeContainer.Text = "Total Call Time";
            this.totalCallTimeContainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalCallTimeContainer.TextOffset = new System.Drawing.Point(0, -5);
            this.totalCallTimeContainer.UseTransparentBackground = true;
            // 
            // totalCallTime
            // 
            this.totalCallTime.AutoSize = true;
            this.totalCallTime.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.totalCallTime.Location = new System.Drawing.Point(30, 41);
            this.totalCallTime.Name = "totalCallTime";
            this.totalCallTime.Size = new System.Drawing.Size(310, 25);
            this.totalCallTime.TabIndex = 1;
            this.totalCallTime.Text = "0 days 0 hours 0 minutes 0 seconds";
            this.totalCallTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgCallTimeContainer
            // 
            this.avgCallTimeContainer.BackColor = System.Drawing.Color.Transparent;
            this.avgCallTimeContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.avgCallTimeContainer.BorderRadius = 5;
            this.avgCallTimeContainer.Controls.Add(this.avgCallTime);
            this.avgCallTimeContainer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.avgCallTimeContainer.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.avgCallTimeContainer.FillColor = System.Drawing.Color.Transparent;
            this.avgCallTimeContainer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgCallTimeContainer.ForeColor = System.Drawing.Color.White;
            this.avgCallTimeContainer.Location = new System.Drawing.Point(13, 217);
            this.avgCallTimeContainer.Name = "avgCallTimeContainer";
            this.avgCallTimeContainer.ShadowDecoration.Parent = this.avgCallTimeContainer;
            this.avgCallTimeContainer.Size = new System.Drawing.Size(376, 79);
            this.avgCallTimeContainer.TabIndex = 6;
            this.avgCallTimeContainer.Text = "AVG Call Time";
            this.avgCallTimeContainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.avgCallTimeContainer.TextOffset = new System.Drawing.Point(0, -5);
            this.avgCallTimeContainer.UseTransparentBackground = true;
            // 
            // avgCallTime
            // 
            this.avgCallTime.AutoSize = true;
            this.avgCallTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.avgCallTime.Location = new System.Drawing.Point(38, 44);
            this.avgCallTime.Name = "avgCallTime";
            this.avgCallTime.Size = new System.Drawing.Size(195, 19);
            this.avgCallTime.TabIndex = 1;
            this.avgCallTime.Text = "0 hours 0 minutes 0 seconds";
            this.avgCallTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startedCallsContainer
            // 
            this.startedCallsContainer.BackColor = System.Drawing.Color.Transparent;
            this.startedCallsContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.startedCallsContainer.BorderRadius = 5;
            this.startedCallsContainer.Controls.Add(this.startedCalls);
            this.startedCallsContainer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.startedCallsContainer.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.startedCallsContainer.FillColor = System.Drawing.Color.Transparent;
            this.startedCallsContainer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startedCallsContainer.ForeColor = System.Drawing.Color.White;
            this.startedCallsContainer.Location = new System.Drawing.Point(406, 118);
            this.startedCallsContainer.Name = "startedCallsContainer";
            this.startedCallsContainer.ShadowDecoration.Parent = this.startedCallsContainer;
            this.startedCallsContainer.Size = new System.Drawing.Size(180, 178);
            this.startedCallsContainer.TabIndex = 7;
            this.startedCallsContainer.Text = "Started Calls";
            this.startedCallsContainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startedCallsContainer.TextOffset = new System.Drawing.Point(0, -5);
            this.startedCallsContainer.UseTransparentBackground = true;
            // 
            // enterIDManuallyCheckBox
            // 
            this.enterIDManuallyCheckBox.Animated = true;
            this.enterIDManuallyCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enterIDManuallyCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enterIDManuallyCheckBox.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.enterIDManuallyCheckBox.CheckedState.InnerColor = System.Drawing.Color.White;
            this.enterIDManuallyCheckBox.CheckedState.Parent = this.enterIDManuallyCheckBox;
            this.enterIDManuallyCheckBox.Location = new System.Drawing.Point(11, 97);
            this.enterIDManuallyCheckBox.Name = "enterIDManuallyCheckBox";
            this.enterIDManuallyCheckBox.ShadowDecoration.Parent = this.enterIDManuallyCheckBox;
            this.enterIDManuallyCheckBox.Size = new System.Drawing.Size(35, 20);
            this.enterIDManuallyCheckBox.TabIndex = 17;
            this.enterIDManuallyCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.enterIDManuallyCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.enterIDManuallyCheckBox.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.enterIDManuallyCheckBox.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.enterIDManuallyCheckBox.UncheckedState.Parent = this.enterIDManuallyCheckBox;
            // 
            // showOutputCheckBox
            // 
            this.showOutputCheckBox.Animated = true;
            this.showOutputCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showOutputCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showOutputCheckBox.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.showOutputCheckBox.CheckedState.InnerColor = System.Drawing.Color.White;
            this.showOutputCheckBox.CheckedState.Parent = this.showOutputCheckBox;
            this.showOutputCheckBox.Location = new System.Drawing.Point(11, 71);
            this.showOutputCheckBox.Name = "showOutputCheckBox";
            this.showOutputCheckBox.ShadowDecoration.Parent = this.showOutputCheckBox;
            this.showOutputCheckBox.Size = new System.Drawing.Size(35, 20);
            this.showOutputCheckBox.TabIndex = 16;
            this.showOutputCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showOutputCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showOutputCheckBox.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.showOutputCheckBox.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.showOutputCheckBox.UncheckedState.Parent = this.showOutputCheckBox;
            // 
            // keepJSONCheckBox
            // 
            this.keepJSONCheckBox.Animated = true;
            this.keepJSONCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keepJSONCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.keepJSONCheckBox.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.keepJSONCheckBox.CheckedState.InnerColor = System.Drawing.Color.White;
            this.keepJSONCheckBox.CheckedState.Parent = this.keepJSONCheckBox;
            this.keepJSONCheckBox.Location = new System.Drawing.Point(11, 45);
            this.keepJSONCheckBox.Name = "keepJSONCheckBox";
            this.keepJSONCheckBox.ShadowDecoration.Parent = this.keepJSONCheckBox;
            this.keepJSONCheckBox.Size = new System.Drawing.Size(35, 20);
            this.keepJSONCheckBox.TabIndex = 15;
            this.keepJSONCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.keepJSONCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.keepJSONCheckBox.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.keepJSONCheckBox.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.keepJSONCheckBox.UncheckedState.Parent = this.keepJSONCheckBox;
            // 
            // startedCalls
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.startedCalls.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.startedCalls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.startedCalls.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.startedCalls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startedCalls.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.startedCalls.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.startedCalls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.startedCalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user,
            this.calls});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.startedCalls.DefaultCellStyle = dataGridViewCellStyle6;
            this.startedCalls.EnableHeadersVisualStyles = false;
            this.startedCalls.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.startedCalls.Location = new System.Drawing.Point(3, 34);
            this.startedCalls.Name = "startedCalls";
            this.startedCalls.RowHeadersVisible = false;
            this.startedCalls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.startedCalls.Size = new System.Drawing.Size(173, 106);
            this.startedCalls.TabIndex = 0;
            this.startedCalls.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.startedCalls.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.startedCalls.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.startedCalls.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.startedCalls.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.startedCalls.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.startedCalls.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.startedCalls.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.startedCalls.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.startedCalls.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startedCalls.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.startedCalls.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.startedCalls.ThemeStyle.HeaderStyle.Height = 23;
            this.startedCalls.ThemeStyle.ReadOnly = false;
            this.startedCalls.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.startedCalls.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.startedCalls.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startedCalls.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.startedCalls.ThemeStyle.RowsStyle.Height = 22;
            this.startedCalls.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.startedCalls.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // user
            // 
            this.user.FillWeight = 98.47716F;
            this.user.HeaderText = "User";
            this.user.Name = "user";
            // 
            // calls
            // 
            this.calls.FillWeight = 101.5228F;
            this.calls.HeaderText = "Calls";
            this.calls.Name = "calls";
            // 
            // operationProgress
            // 
            this.operationProgress.Animated = true;
            this.operationProgress.AnimationSpeed = 1F;
            this.operationProgress.BackColor = System.Drawing.Color.Transparent;
            this.operationProgress.FillColor = System.Drawing.Color.Transparent;
            this.operationProgress.FillThickness = 20;
            this.operationProgress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.operationProgress.ForeColor = System.Drawing.Color.White;
            this.operationProgress.InnerColor = System.Drawing.Color.Transparent;
            this.operationProgress.Location = new System.Drawing.Point(272, 44);
            this.operationProgress.Minimum = 0;
            this.operationProgress.Name = "operationProgress";
            this.operationProgress.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            this.operationProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.operationProgress.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.operationProgress.ProgressThickness = 5;
            this.operationProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.operationProgress.ShadowDecoration.Parent = this.operationProgress;
            this.operationProgress.Size = new System.Drawing.Size(60, 60);
            this.operationProgress.TabIndex = 8;
            this.operationProgress.Text = "guna2CircleProgressBar1";
            this.operationProgress.UseTransparentBackground = true;
            this.operationProgress.Value = 25;
            // 
            // importJSON
            // 
            this.importJSON.BackColor = System.Drawing.Color.Transparent;
            this.importJSON.BorderColor = System.Drawing.Color.Transparent;
            this.importJSON.BorderRadius = 4;
            this.importJSON.CheckedState.Parent = this.importJSON;
            this.importJSON.CustomImages.Parent = this.importJSON;
            this.importJSON.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.importJSON.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.importJSON.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.importJSON.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.importJSON.DisabledState.Parent = this.importJSON;
            this.importJSON.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(82)))));
            this.importJSON.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.importJSON.ForeColor = System.Drawing.Color.Black;
            this.importJSON.HoverState.Parent = this.importJSON;
            this.importJSON.Location = new System.Drawing.Point(13, 470);
            this.importJSON.Name = "importJSON";
            this.importJSON.ShadowDecoration.Parent = this.importJSON;
            this.importJSON.Size = new System.Drawing.Size(120, 30);
            this.importJSON.TabIndex = 9;
            this.importJSON.Text = "Import JSON";
            this.importJSON.UseTransparentBackground = true;
            // 
            // trustLabel
            // 
            this.trustLabel.AutoSize = true;
            this.trustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.trustLabel.ForeColor = System.Drawing.Color.White;
            this.trustLabel.Location = new System.Drawing.Point(141, 476);
            this.trustLabel.Name = "trustLabel";
            this.trustLabel.Size = new System.Drawing.Size(171, 15);
            this.trustLabel.TabIndex = 10;
            this.trustLabel.Text = "<--- if you don\'t trust the devs :(";
            // 
            // jsonFileBrowser
            // 
            this.jsonFileBrowser.FileName = "messages.json";
            this.jsonFileBrowser.Title = "JSON Selector";
            // 
            // chatIDCombo
            // 
            this.chatIDCombo.BackColor = System.Drawing.Color.Transparent;
            this.chatIDCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.chatIDCombo.BorderRadius = 5;
            this.chatIDCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.chatIDCombo.DropDownHeight = 300;
            this.chatIDCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chatIDCombo.DropDownWidth = 200;
            this.chatIDCombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.chatIDCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chatIDCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chatIDCombo.FocusedState.Parent = this.chatIDCombo;
            this.chatIDCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatIDCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.chatIDCombo.HoverState.Parent = this.chatIDCombo;
            this.chatIDCombo.IntegralHeight = false;
            this.chatIDCombo.ItemHeight = 34;
            this.chatIDCombo.ItemsAppearance.Parent = this.chatIDCombo;
            this.chatIDCombo.Location = new System.Drawing.Point(343, 53);
            this.chatIDCombo.Name = "chatIDCombo";
            this.chatIDCombo.ShadowDecoration.Parent = this.chatIDCombo;
            this.chatIDCombo.Size = new System.Drawing.Size(243, 40);
            this.chatIDCombo.TabIndex = 11;
            this.chatIDCombo.SelectedIndexChanged += new System.EventHandler(this.chatIDCombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Keep Chat File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Debug Mode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Manual Chat ID";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.keepJSONCheckBox);
            this.guna2GroupBox1.Controls.Add(this.enterIDManuallyCheckBox);
            this.guna2GroupBox1.Controls.Add(this.showOutputCheckBox);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(409, 315);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(177, 185);
            this.guna2GroupBox1.TabIndex = 21;
            this.guna2GroupBox1.Text = "Options";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, -5);
            this.guna2GroupBox1.UseTransparentBackground = true;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.guna2GroupBox2.BorderRadius = 5;
            this.guna2GroupBox2.Controls.Add(this.label7);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(13, 315);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(376, 149);
            this.guna2GroupBox2.TabIndex = 7;
            this.guna2GroupBox2.Text = "Advanced Info";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox2.TextOffset = new System.Drawing.Point(0, -5);
            this.guna2GroupBox2.UseTransparentBackground = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(38, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "0 hours 0 minutes 0 seconds";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(602, 512);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.chatIDCombo);
            this.Controls.Add(this.trustLabel);
            this.Controls.Add(this.importJSON);
            this.Controls.Add(this.startedCallsContainer);
            this.Controls.Add(this.avgCallTimeContainer);
            this.Controls.Add(this.totalCallTimeContainer);
            this.Controls.Add(this.chatIdField);
            this.Controls.Add(this.tokenField);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.operationProgress);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DiscordTotalCallTime";
            this.dragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.softwareIcon)).EndInit();
            this.totalCallTimeContainer.ResumeLayout(false);
            this.totalCallTimeContainer.PerformLayout();
            this.avgCallTimeContainer.ResumeLayout(false);
            this.avgCallTimeContainer.PerformLayout();
            this.startedCallsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startedCalls)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dragPanel;
        private Guna.UI2.WinForms.Guna2CircleButton closeBtn;
        private Guna.UI2.WinForms.Guna2TextBox tokenField;
        private Guna.UI2.WinForms.Guna2TextBox chatIdField;
        private Guna.UI2.WinForms.Guna2CircleButton confirmBtn;
        private Guna.UI2.WinForms.Guna2GroupBox totalCallTimeContainer;
        private System.Windows.Forms.Label totalCallTime;
        private Guna.UI2.WinForms.Guna2GroupBox avgCallTimeContainer;
        private System.Windows.Forms.Label avgCallTime;
        private Guna.UI2.WinForms.Guna2GroupBox startedCallsContainer;
        private Guna.UI2.WinForms.Guna2DataGridView startedCalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn calls;
        private Guna.UI2.WinForms.Guna2CircleProgressBar operationProgress;
        private Guna.UI2.WinForms.Guna2Button importJSON;
        private System.Windows.Forms.PictureBox softwareIcon;
        private System.Windows.Forms.Label trustLabel;
        private System.Windows.Forms.OpenFileDialog jsonFileBrowser;
        private Guna.UI2.WinForms.Guna2ComboBox chatIDCombo;
        private Guna.UI2.WinForms.Guna2ToggleSwitch enterIDManuallyCheckBox;
        private Guna.UI2.WinForms.Guna2ToggleSwitch showOutputCheckBox;
        private Guna.UI2.WinForms.Guna2ToggleSwitch keepJSONCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label7;
    }
}

