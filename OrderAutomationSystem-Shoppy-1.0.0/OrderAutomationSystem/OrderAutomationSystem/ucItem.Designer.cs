
namespace OrderAutomationSystem
{
    partial class ucItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucItem));
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.checkedBox = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.BorderRadius = 10;
            this.pictureBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Location = new System.Drawing.Point(27, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.ShadowDecoration.Parent = this.pictureBox;
            this.pictureBox.Size = new System.Drawing.Size(153, 133);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblName.Location = new System.Drawing.Point(6, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(12, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "l";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.Green;
            this.lblPrice.Location = new System.Drawing.Point(89, 165);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(18, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "0";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.mainPanel.BorderRadius = 10;
            this.mainPanel.Controls.Add(this.checkedBox);
            this.mainPanel.Controls.Add(this.pictureBox);
            this.mainPanel.Controls.Add(this.lblName);
            this.mainPanel.Controls.Add(this.lblPrice);
            this.mainPanel.Location = new System.Drawing.Point(22, 15);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(201, 195);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Click += new System.EventHandler(this.mainPanel_Click);
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // checkedBox
            // 
            this.checkedBox.BorderRadius = 10;
            this.checkedBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.checkedBox.Image = ((System.Drawing.Image)(resources.GetObject("checkedBox.Image")));
            this.checkedBox.ImageRotate = 0F;
            this.checkedBox.Location = new System.Drawing.Point(144, 159);
            this.checkedBox.Name = "checkedBox";
            this.checkedBox.ShadowDecoration.Parent = this.checkedBox;
            this.checkedBox.Size = new System.Drawing.Size(54, 35);
            this.checkedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkedBox.TabIndex = 0;
            this.checkedBox.TabStop = false;
            // 
            // ucItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mainPanel);
            this.Name = "ucItem";
            this.Size = new System.Drawing.Size(247, 228);
            this.Load += new System.EventHandler(this.ucItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2PictureBox checkedBox;
    }
}
