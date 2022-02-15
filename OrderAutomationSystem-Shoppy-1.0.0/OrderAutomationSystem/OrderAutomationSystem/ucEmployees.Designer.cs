
namespace OrderAutomationSystem
{
    partial class ucEmployees
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
            this.txtEmployeeSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployeeSearch
            // 
            this.txtEmployeeSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtEmployeeSearch.BorderRadius = 15;
            this.txtEmployeeSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeSearch.DefaultText = "Enter Employee ID";
            this.txtEmployeeSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeeSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeeSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeSearch.DisabledState.Parent = this.txtEmployeeSearch;
            this.txtEmployeeSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeSearch.FocusedState.Parent = this.txtEmployeeSearch;
            this.txtEmployeeSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeeSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeSearch.HoverState.Parent = this.txtEmployeeSearch;
            this.txtEmployeeSearch.Location = new System.Drawing.Point(40, 38);
            this.txtEmployeeSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeSearch.Name = "txtEmployeeSearch";
            this.txtEmployeeSearch.PasswordChar = '\0';
            this.txtEmployeeSearch.PlaceholderText = "";
            this.txtEmployeeSearch.SelectedText = "";
            this.txtEmployeeSearch.SelectionStart = 17;
            this.txtEmployeeSearch.ShadowDecoration.Parent = this.txtEmployeeSearch;
            this.txtEmployeeSearch.Size = new System.Drawing.Size(312, 45);
            this.txtEmployeeSearch.TabIndex = 8;
            this.txtEmployeeSearch.Click += new System.EventHandler(this.txtEmployeeSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 27;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.DisabledState.Parent = this.btnSearch;
            this.btnSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(374, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(141, 56);
            this.btnSearch.TabIndex = 257;
            this.btnSearch.Text = "Search";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(40, 282);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(1114, 635);
            this.dgvEmployees.TabIndex = 258;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick_1);
            // 
            // ucEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEmployeeSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucEmployees";
            this.Size = new System.Drawing.Size(1238, 1025);
            this.Load += new System.EventHandler(this.ucEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeeSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private System.Windows.Forms.DataGridView dgvEmployees;
    }
}
