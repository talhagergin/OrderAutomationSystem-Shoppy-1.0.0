
namespace OrderAutomationSystem
{
    partial class orderPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderPayment));
            this.pctOk = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblmessage1 = new System.Windows.Forms.Label();
            this.lblThank = new System.Windows.Forms.Label();
            this.lblmessage2 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctOk)).BeginInit();
            this.SuspendLayout();
            // 
            // pctOk
            // 
            this.pctOk.BackColor = System.Drawing.Color.Transparent;
            this.pctOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctOk.BackgroundImage")));
            this.pctOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctOk.FillColor = System.Drawing.Color.Transparent;
            this.pctOk.ImageRotate = 0F;
            this.pctOk.Location = new System.Drawing.Point(269, 10);
            this.pctOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctOk.Name = "pctOk";
            this.pctOk.ShadowDecoration.Parent = this.pctOk;
            this.pctOk.Size = new System.Drawing.Size(75, 81);
            this.pctOk.TabIndex = 0;
            this.pctOk.TabStop = false;
            // 
            // lblmessage1
            // 
            this.lblmessage1.AutoSize = true;
            this.lblmessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmessage1.Location = new System.Drawing.Point(143, 94);
            this.lblmessage1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmessage1.Name = "lblmessage1";
            this.lblmessage1.Size = new System.Drawing.Size(352, 40);
            this.lblmessage1.TabIndex = 1;
            this.lblmessage1.Text = "\r\nYour order has been received successfully.";
            // 
            // lblThank
            // 
            this.lblThank.AutoSize = true;
            this.lblThank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblThank.Location = new System.Drawing.Point(266, 93);
            this.lblThank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThank.Name = "lblThank";
            this.lblThank.Size = new System.Drawing.Size(72, 20);
            this.lblThank.TabIndex = 2;
            this.lblThank.Text = "Thanks!";
            // 
            // lblmessage2
            // 
            this.lblmessage2.AutoSize = true;
            this.lblmessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmessage2.Location = new System.Drawing.Point(71, 145);
            this.lblmessage2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmessage2.Name = "lblmessage2";
            this.lblmessage2.Size = new System.Drawing.Size(467, 30);
            this.lblmessage2.TabIndex = 3;
            this.lblmessage2.Text = "The products you order will be delivered to your delivery address as soon as poss" +
    "ible.\r\nThank you for choosing us for your shopping.";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExit.Location = new System.Drawing.Point(616, 7);
            this.lblExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(19, 18);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // orderPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 229);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblmessage2);
            this.Controls.Add(this.lblThank);
            this.Controls.Add(this.lblmessage1);
            this.Controls.Add(this.pctOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "orderPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderSuccessfull";
            ((System.ComponentModel.ISupportInitialize)(this.pctOk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pctOk;
        private System.Windows.Forms.Label lblmessage1;
        private System.Windows.Forms.Label lblThank;
        private System.Windows.Forms.Label lblmessage2;
        private System.Windows.Forms.Label lblExit;
    }
}