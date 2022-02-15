
namespace OrderAutomationSystem
{
    partial class loginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPanel));
            this.pictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.usernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.registerButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.passButton = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Location = new System.Drawing.Point(142, 63);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox.ShadowDecoration.Parent = this.pictureBox;
            this.pictureBox.Size = new System.Drawing.Size(241, 211);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.BorderRadius = 23;
            this.usernameBox.BorderThickness = 0;
            this.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.DefaultText = "";
            this.usernameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBox.DisabledState.Parent = this.usernameBox;
            this.usernameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.usernameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameBox.FocusedState.Parent = this.usernameBox;
            this.usernameBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.usernameBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.usernameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameBox.HoverState.Parent = this.usernameBox;
            this.usernameBox.Location = new System.Drawing.Point(142, 411);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(134)))));
            this.usernameBox.PlaceholderText = "Email";
            this.usernameBox.SelectedText = "";
            this.usernameBox.ShadowDecoration.Parent = this.usernameBox;
            this.usernameBox.Size = new System.Drawing.Size(241, 45);
            this.usernameBox.TabIndex = 251;
            this.usernameBox.Enter += new System.EventHandler(this.usernameBox_Enter);
            this.usernameBox.Leave += new System.EventHandler(this.usernameBox_Leave);
            // 
            // passwordBox
            // 
            this.passwordBox.BorderRadius = 23;
            this.passwordBox.BorderThickness = 0;
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.DefaultText = "";
            this.passwordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.DisabledState.Parent = this.passwordBox;
            this.passwordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.passwordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.FocusedState.Parent = this.passwordBox;
            this.passwordBox.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.passwordBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.passwordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.HoverState.Parent = this.passwordBox;
            this.passwordBox.Location = new System.Drawing.Point(142, 481);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(134)))));
            this.passwordBox.PlaceholderText = "Password";
            this.passwordBox.SelectedText = "";
            this.passwordBox.ShadowDecoration.Parent = this.passwordBox;
            this.passwordBox.Size = new System.Drawing.Size(241, 45);
            this.passwordBox.TabIndex = 252;
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // loginButton
            // 
            this.loginButton.Animated = true;
            this.loginButton.AutoRoundedCorners = true;
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BorderRadius = 21;
            this.loginButton.CheckedState.Parent = this.loginButton;
            this.loginButton.CustomImages.Parent = this.loginButton;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.DisabledState.Parent = this.loginButton;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.loginButton.HoverState.Parent = this.loginButton;
            this.loginButton.Location = new System.Drawing.Point(273, 551);
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.Parent = this.loginButton;
            this.loginButton.Size = new System.Drawing.Size(110, 45);
            this.loginButton.TabIndex = 255;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Animated = true;
            this.registerButton.AutoRoundedCorners = true;
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.BorderRadius = 21;
            this.registerButton.CheckedState.Parent = this.registerButton;
            this.registerButton.CustomImages.Parent = this.registerButton;
            this.registerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerButton.DisabledState.Parent = this.registerButton;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.registerButton.HoverState.Parent = this.registerButton;
            this.registerButton.Location = new System.Drawing.Point(142, 551);
            this.registerButton.Name = "registerButton";
            this.registerButton.ShadowDecoration.Parent = this.registerButton;
            this.registerButton.Size = new System.Drawing.Size(110, 45);
            this.registerButton.TabIndex = 254;
            this.registerButton.Text = "Register";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passButton
            // 
            this.passButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.passButton.FlatAppearance.BorderSize = 0;
            this.passButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.passButton.IconColor = System.Drawing.Color.Black;
            this.passButton.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.passButton.IconSize = 25;
            this.passButton.Location = new System.Drawing.Point(338, 491);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(34, 27);
            this.passButton.TabIndex = 253;
            this.passButton.UseVisualStyleBackColor = false;
            this.passButton.Click += new System.EventHandler(this.passButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(489, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(49, 37);
            this.closeButton.TabIndex = 256;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(434, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(49, 37);
            this.minimizeButton.TabIndex = 256;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // loginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(537, 711);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.passButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.loginPanel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2TextBox usernameBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordBox;
        private Guna.UI2.WinForms.Guna2GradientButton loginButton;
        private Guna.UI2.WinForms.Guna2GradientButton registerButton;
        private FontAwesome.Sharp.IconButton passButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
    }
}

