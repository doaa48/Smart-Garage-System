namespace GarageSystem
{
    partial class Splash_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash_Form));
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Label_Exit = new System.Windows.Forms.Label();
            this.timer_Splash = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2CircleButton1.HoverState.CustomBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2CircleButton1.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2CircleButton1.Location = new System.Drawing.Point(-142, -9);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(360, 464);
            this.guna2CircleButton1.TabIndex = 0;
            this.guna2CircleButton1.Text = " ";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.InitialImage")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(37, 107);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(270, 250);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // Label_Exit
            // 
            this.Label_Exit.AutoSize = true;
            this.Label_Exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Exit.Location = new System.Drawing.Point(761, 9);
            this.Label_Exit.Name = "Label_Exit";
            this.Label_Exit.Size = new System.Drawing.Size(27, 26);
            this.Label_Exit.TabIndex = 7;
            this.Label_Exit.Text = "X";
            this.Label_Exit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Label_Exit.Click += new System.EventHandler(this.Label_Exit_Click);
            // 
            // timer_Splash
            // 
            this.timer_Splash.Tick += new System.EventHandler(this.timer_Splash_Tick);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar1.FillColor = System.Drawing.SystemColors.Control;
            this.ProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProgressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.ProgressBar1.Location = new System.Drawing.Point(20, 88);
            this.ProgressBar1.Minimum = 0;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.ProgressColor = System.Drawing.SystemColors.Control;
            this.ProgressBar1.ProgressColor2 = System.Drawing.Color.Black;
            this.ProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressBar1.Size = new System.Drawing.Size(287, 287);
            this.ProgressBar1.TabIndex = 8;
            this.ProgressBar1.Text = " ";
            this.ProgressBar1.UseTransparentBackground = true;
            // 
            // Splash_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.Label_Exit);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2CircleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Splash_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label Label_Exit;
        private System.Windows.Forms.Timer timer_Splash;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBar1;
    }
}

