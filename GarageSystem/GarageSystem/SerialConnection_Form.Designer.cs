namespace GarageSystem
{
    partial class SerialConnection_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialConnection_Form));
            this.Button_StopConnection = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.Label_Current_Time = new System.Windows.Forms.Label();
            this.Button_StartConnection = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox_Minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_Maximize = new System.Windows.Forms.PictureBox();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2ComboBoxParity = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBoxStopBits = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBoxDataBits = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2ComboBoxCOMPort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBoxBaudRate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.richTextBoxSerialDataTransciever = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_StopConnection
            // 
            this.Button_StopConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_StopConnection.AutoRoundedCorners = true;
            this.Button_StopConnection.BorderRadius = 23;
            this.Button_StopConnection.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_StopConnection.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_StopConnection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_StopConnection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_StopConnection.FillColor = System.Drawing.Color.Brown;
            this.Button_StopConnection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StopConnection.ForeColor = System.Drawing.Color.White;
            this.Button_StopConnection.Location = new System.Drawing.Point(239, 583);
            this.Button_StopConnection.Name = "Button_StopConnection";
            this.Button_StopConnection.Size = new System.Drawing.Size(134, 49);
            this.Button_StopConnection.TabIndex = 82;
            this.Button_StopConnection.Text = "Stop";
            this.Button_StopConnection.Click += new System.EventHandler(this.Button_StopConnection_Click);
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.AutoRoundedCorners = true;
            this.Button_Refresh.BorderRadius = 23;
            this.Button_Refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Refresh.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.Button_Refresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Refresh.ForeColor = System.Drawing.Color.White;
            this.Button_Refresh.Location = new System.Drawing.Point(47, 55);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(141, 49);
            this.Button_Refresh.TabIndex = 81;
            this.Button_Refresh.Text = "Refresh";
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // Label_Current_Time
            // 
            this.Label_Current_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Current_Time.AutoSize = true;
            this.Label_Current_Time.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Current_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Current_Time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label_Current_Time.Location = new System.Drawing.Point(725, 675);
            this.Label_Current_Time.Name = "Label_Current_Time";
            this.Label_Current_Time.Size = new System.Drawing.Size(10, 16);
            this.Label_Current_Time.TabIndex = 78;
            this.Label_Current_Time.Text = " ";
            // 
            // Button_StartConnection
            // 
            this.Button_StartConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_StartConnection.AutoRoundedCorners = true;
            this.Button_StartConnection.BorderRadius = 23;
            this.Button_StartConnection.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_StartConnection.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_StartConnection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_StartConnection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_StartConnection.FillColor = System.Drawing.Color.ForestGreen;
            this.Button_StartConnection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StartConnection.ForeColor = System.Drawing.Color.White;
            this.Button_StartConnection.Location = new System.Drawing.Point(47, 583);
            this.Button_StartConnection.Name = "Button_StartConnection";
            this.Button_StartConnection.Size = new System.Drawing.Size(138, 49);
            this.Button_StartConnection.TabIndex = 80;
            this.Button_StartConnection.Text = "Start";
            this.Button_StartConnection.Click += new System.EventHandler(this.Button_StartConnection_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Button2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Button2.CustomBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Black;
            this.guna2Button2.FocusedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button2.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button2.Location = new System.Drawing.Point(-5, 669);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button2.Size = new System.Drawing.Size(1011, 33);
            this.guna2Button2.TabIndex = 79;
            this.guna2Button2.Text = " ";
            // 
            // pictureBox_Minimize
            // 
            this.pictureBox_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Minimize.BackColor = System.Drawing.Color.Gold;
            this.pictureBox_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Minimize.Image")));
            this.pictureBox_Minimize.Location = new System.Drawing.Point(872, 0);
            this.pictureBox_Minimize.Name = "pictureBox_Minimize";
            this.pictureBox_Minimize.Size = new System.Drawing.Size(27, 25);
            this.pictureBox_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Minimize.TabIndex = 74;
            this.pictureBox_Minimize.TabStop = false;
            this.pictureBox_Minimize.Click += new System.EventHandler(this.pictureBox_Minimize_Click);
            // 
            // pictureBox_Maximize
            // 
            this.pictureBox_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Maximize.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox_Maximize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Maximize.Image")));
            this.pictureBox_Maximize.Location = new System.Drawing.Point(919, -2);
            this.pictureBox_Maximize.Name = "pictureBox_Maximize";
            this.pictureBox_Maximize.Size = new System.Drawing.Size(28, 27);
            this.pictureBox_Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Maximize.TabIndex = 75;
            this.pictureBox_Maximize.TabStop = false;
            this.pictureBox_Maximize.Click += new System.EventHandler(this.pictureBox_Maximize_Click);
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit.Image")));
            this.pictureBox_Exit.Location = new System.Drawing.Point(965, 0);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(24, 25);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Exit.TabIndex = 76;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button1.CustomBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.FocusedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button1.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button1.Location = new System.Drawing.Point(-5, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button1.Size = new System.Drawing.Size(1011, 33);
            this.guna2Button1.TabIndex = 77;
            this.guna2Button1.Text = " ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 74);
            this.label7.TabIndex = 9;
            this.label7.Text = "Data Bits";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 403);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slot Information";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.97959F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.02041F));
            this.tableLayoutPanel3.Controls.Add(this.guna2ComboBoxParity, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.guna2ComboBoxStopBits, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.guna2ComboBoxDataBits, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.guna2ComboBoxCOMPort, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.guna2ComboBoxBaudRate, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(362, 373);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // guna2ComboBoxParity
            // 
            this.guna2ComboBoxParity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ComboBoxParity.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxParity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxParity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxParity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxParity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBoxParity.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBoxParity.ItemHeight = 30;
            this.guna2ComboBoxParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.guna2ComboBoxParity.Location = new System.Drawing.Point(180, 316);
            this.guna2ComboBoxParity.Name = "guna2ComboBoxParity";
            this.guna2ComboBoxParity.Size = new System.Drawing.Size(179, 36);
            this.guna2ComboBoxParity.TabIndex = 16;
            // 
            // guna2ComboBoxStopBits
            // 
            this.guna2ComboBoxStopBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ComboBoxStopBits.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxStopBits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxStopBits.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxStopBits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxStopBits.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBoxStopBits.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBoxStopBits.ItemHeight = 30;
            this.guna2ComboBoxStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.guna2ComboBoxStopBits.Location = new System.Drawing.Point(180, 241);
            this.guna2ComboBoxStopBits.Name = "guna2ComboBoxStopBits";
            this.guna2ComboBoxStopBits.Size = new System.Drawing.Size(179, 36);
            this.guna2ComboBoxStopBits.TabIndex = 15;
            // 
            // guna2ComboBoxDataBits
            // 
            this.guna2ComboBoxDataBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ComboBoxDataBits.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxDataBits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxDataBits.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxDataBits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxDataBits.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBoxDataBits.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBoxDataBits.ItemHeight = 30;
            this.guna2ComboBoxDataBits.Items.AddRange(new object[] {
            "8",
            "9"});
            this.guna2ComboBoxDataBits.Location = new System.Drawing.Point(180, 167);
            this.guna2ComboBoxDataBits.Name = "guna2ComboBoxDataBits";
            this.guna2ComboBoxDataBits.Size = new System.Drawing.Size(179, 36);
            this.guna2ComboBoxDataBits.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 77);
            this.label5.TabIndex = 11;
            this.label5.Text = "Parity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 74);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stop Bits";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 74);
            this.label3.TabIndex = 2;
            this.label3.Text = "Baudrate";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 74);
            this.label6.TabIndex = 0;
            this.label6.Text = "COM Port";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2ComboBoxCOMPort
            // 
            this.guna2ComboBoxCOMPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ComboBoxCOMPort.AutoCompleteCustomSource.AddRange(new string[] {
            "COM0 ",
            "COM1"});
            this.guna2ComboBoxCOMPort.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxCOMPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxCOMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxCOMPort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxCOMPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxCOMPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBoxCOMPort.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBoxCOMPort.ItemHeight = 30;
            this.guna2ComboBoxCOMPort.Location = new System.Drawing.Point(180, 19);
            this.guna2ComboBoxCOMPort.Name = "guna2ComboBoxCOMPort";
            this.guna2ComboBoxCOMPort.Size = new System.Drawing.Size(179, 36);
            this.guna2ComboBoxCOMPort.TabIndex = 12;
            this.guna2ComboBoxCOMPort.Click += new System.EventHandler(this.guna2ComboBoxCOMPort_Click);
            // 
            // guna2ComboBoxBaudRate
            // 
            this.guna2ComboBoxBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ComboBoxBaudRate.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxBaudRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxBaudRate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxBaudRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxBaudRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBoxBaudRate.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBoxBaudRate.ItemHeight = 30;
            this.guna2ComboBoxBaudRate.Items.AddRange(new object[] {
            " 4800",
            " 9600",
            " 19200",
            " 38400",
            " 57600",
            " 115200",
            " 230400",
            " 460800",
            " 921600"});
            this.guna2ComboBoxBaudRate.Location = new System.Drawing.Point(180, 93);
            this.guna2ComboBoxBaudRate.Name = "guna2ComboBoxBaudRate";
            this.guna2ComboBoxBaudRate.Size = new System.Drawing.Size(179, 36);
            this.guna2ComboBoxBaudRate.TabIndex = 13;
            this.guna2ComboBoxBaudRate.Tag = "";
            // 
            // richTextBoxSerialDataTransciever
            // 
            this.richTextBoxSerialDataTransciever.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxSerialDataTransciever.Location = new System.Drawing.Point(431, 55);
            this.richTextBoxSerialDataTransciever.Name = "richTextBoxSerialDataTransciever";
            this.richTextBoxSerialDataTransciever.Size = new System.Drawing.Size(546, 586);
            this.richTextBoxSerialDataTransciever.TabIndex = 83;
            this.richTextBoxSerialDataTransciever.Text = "";
            this.richTextBoxSerialDataTransciever.TextChanged += new System.EventHandler(this.richTextBoxSerialDataTransciever_TextChanged);
            // 
            // SerialConnection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.richTextBoxSerialDataTransciever);
            this.Controls.Add(this.Button_StopConnection);
            this.Controls.Add(this.Button_Refresh);
            this.Controls.Add(this.Label_Current_Time);
            this.Controls.Add(this.Button_StartConnection);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.pictureBox_Minimize);
            this.Controls.Add(this.pictureBox_Maximize);
            this.Controls.Add(this.pictureBox_Exit);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SerialConnection_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SerialConnection_Form";
            this.Load += new System.EventHandler(this.SerialConnection_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Button_StopConnection;
        private Guna.UI2.WinForms.Guna2Button Button_Refresh;
        private System.Windows.Forms.Label Label_Current_Time;
        private Guna.UI2.WinForms.Guna2Button Button_StartConnection;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.PictureBox pictureBox_Minimize;
        private System.Windows.Forms.PictureBox pictureBox_Maximize;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxSerialDataTransciever;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxParity;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxStopBits;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxDataBits;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxCOMPort;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxBaudRate;
    }
}