
namespace OrderAutomationSystem
{
    partial class ucStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStatistics));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            this.lblEarning = new System.Windows.Forms.Label();
            this.pctMoney = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(26, 234);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(454, 376);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMoney.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(58, 103);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(54, 26);
            this.lblMoney.TabIndex = 4;
            this.lblMoney.Text = "0,00";
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.BackColor = System.Drawing.Color.Transparent;
            this.lblTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTL.ForeColor = System.Drawing.Color.White;
            this.lblTL.Location = new System.Drawing.Point(31, 103);
            this.lblTL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(24, 26);
            this.lblTL.TabIndex = 5;
            this.lblTL.Text = "₺";
            // 
            // lblEarning
            // 
            this.lblEarning.AutoSize = true;
            this.lblEarning.BackColor = System.Drawing.Color.Transparent;
            this.lblEarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEarning.ForeColor = System.Drawing.Color.White;
            this.lblEarning.Location = new System.Drawing.Point(21, 44);
            this.lblEarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEarning.Name = "lblEarning";
            this.lblEarning.Size = new System.Drawing.Size(103, 29);
            this.lblEarning.TabIndex = 6;
            this.lblEarning.Text = "Earning";
            // 
            // pctMoney
            // 
            this.pctMoney.Image = ((System.Drawing.Image)(resources.GetObject("pctMoney.Image")));
            this.pctMoney.Location = new System.Drawing.Point(155, 44);
            this.pctMoney.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctMoney.Name = "pctMoney";
            this.pctMoney.Size = new System.Drawing.Size(90, 106);
            this.pctMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMoney.TabIndex = 3;
            this.pctMoney.TabStop = false;
            // 
            // ucStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblTL);
            this.Controls.Add(this.lblEarning);
            this.Controls.Add(this.pctMoney);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucStatistics";
            this.Size = new System.Drawing.Size(825, 666);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.Label lblEarning;
        private System.Windows.Forms.PictureBox pctMoney;
    }
}
