
namespace OrderAutomationSystem
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.desLabel = new System.Windows.Forms.Label();
            this.welcomeGif = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.checkBox = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeGif)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(531, 437);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.Violet;
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.progressBar.ShadowDecoration.Parent = this.progressBar;
            this.progressBar.Size = new System.Drawing.Size(325, 10);
            this.progressBar.TabIndex = 0;
            this.progressBar.Text = "progressBar";
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainLabel.Location = new System.Drawing.Point(145, 90);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(195, 46);
            this.mainLabel.TabIndex = 2;
            this.mainLabel.Text = "Welcome";
            // 
            // desLabel
            // 
            this.desLabel.AutoSize = true;
            this.desLabel.Font = new System.Drawing.Font("Microsoft Yi Baiti", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.desLabel.Location = new System.Drawing.Point(33, 255);
            this.desLabel.Name = "desLabel";
            this.desLabel.Size = new System.Drawing.Size(370, 66);
            this.desLabel.TabIndex = 3;
            this.desLabel.Text = "We are working to improve\r\nyour experience\r\n";
            // 
            // welcomeGif
            // 
            this.welcomeGif.Image = ((System.Drawing.Image)(resources.GetObject("welcomeGif.Image")));
            this.welcomeGif.Location = new System.Drawing.Point(22, 139);
            this.welcomeGif.Name = "welcomeGif";
            this.welcomeGif.Size = new System.Drawing.Size(446, 50);
            this.welcomeGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.welcomeGif.TabIndex = 4;
            this.welcomeGif.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nameLabel.Location = new System.Drawing.Point(426, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(111, 34);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Shoppy";
            // 
            // checkBox
            // 
            this.checkBox.Animated = true;
            this.checkBox.CheckedState.BorderColor = System.Drawing.Color.Violet;
            this.checkBox.CheckedState.BorderRadius = 0;
            this.checkBox.CheckedState.BorderThickness = 2;
            this.checkBox.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.checkBox.CheckedState.Parent = this.checkBox;
            this.checkBox.CheckMarkColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBox.Location = new System.Drawing.Point(61, 427);
            this.checkBox.Name = "checkBox";
            this.checkBox.ShadowDecoration.Parent = this.checkBox;
            this.checkBox.Size = new System.Drawing.Size(20, 20);
            this.checkBox.TabIndex = 6;
            this.checkBox.Text = "guna2CustomCheckBox1";
            this.checkBox.UncheckedState.BorderColor = System.Drawing.Color.Violet;
            this.checkBox.UncheckedState.BorderRadius = 0;
            this.checkBox.UncheckedState.BorderThickness = 2;
            this.checkBox.UncheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.checkBox.UncheckedState.Parent = this.checkBox;
            this.checkBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Allow anonymous usage statistics to be collected\r\nto help improve the experience " +
    "of the application\r\n\r\n";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(958, 518);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.welcomeGif);
            this.Controls.Add(this.desLabel);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label desLabel;
        private System.Windows.Forms.PictureBox welcomeGif;
        private System.Windows.Forms.Label nameLabel;
        private Guna.UI2.WinForms.Guna2CustomCheckBox checkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}