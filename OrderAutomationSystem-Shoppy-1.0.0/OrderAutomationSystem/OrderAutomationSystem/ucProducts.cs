using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace OrderAutomationSystem
{
    public partial class ucProducts : UserControl
    {

        int? id = null;
        public bool save = false;
        SQLiteCommand cmd;
        DataSet ds = new DataSet();

        BindingSource bd = new BindingSource();
        public ucProducts()
        {
            InitializeComponent();
            using (SQLiteConnection sql = new SQLiteConnection("Data source=.\\dataBase.db"))
            {
                sql.Open();
                cmd = sql.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Items";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                dataAdapter.Fill(ds);
                sql.Close();
            }
            bd.DataSource = ds.Tables[0];
            dgvProducts.DataSource = bd;
        }

        public ucProducts(int? Id = null) : this()
        {

            List();
            if (Id != null)
                this.id = Id;
        }

        void List()
        {
            string sql = "Select * from Items";
            dgvProducts.DataSource = Crud.List(sql);
        }
        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
        }

        private void txtQuantity_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = string.Empty;
        }

        private void txtWeight_Click(object sender, EventArgs e)
        {
            txtWeight.Text = string.Empty;
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            txtPrice.Text = string.Empty;
        }
        //DataBaseye ekleme işlemi
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            using (SQLiteConnection sql = new SQLiteConnection("Data source=.\\dataBase.db"))
            {
                sql.Open();
                cmd = sql.CreateCommand();
                cmd.CommandText = @"INSERT INTO Items (Name, Quantity, Weight, Description, Price, Tag) VALUES ('" + txtName.Text + "','" + txtQuantity.Text + "','" + txtWeight.Text + "','" + txtDescription.Text + "','"+txtPrice.Text+"','" + txtTag.Text + "')";

                cmd.ExecuteNonQuery();
                cmd = sql.CreateCommand();
                cmd.CommandText = @"SELECT * FROM Items";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                ds.Clear();//Dataseti 0 lar
                dataAdapter.Fill(ds);
                sql.Close();
            }
        }

        //DataGridView değiştirilirse etkisini databasede de yapar
        private void dgvProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            var deger = dgvProducts.Rows[rowIndex].Cells[columnIndex].Value;
            var name = dgvProducts.Columns[columnIndex].DataPropertyName;
            int index = Convert.ToInt32(dgvProducts.Rows[rowIndex].Cells[0].Value);
            if (name == "ItemID")
            {
                MessageBox.Show("IDler değiştirilemez değiştirmek için yönetici ile görüşün", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
                return;
            }
           
                using (SQLiteConnection sql = new SQLiteConnection("Data source=.\\dataBase.db"))
                {
                    sql.Open();
                    cmd = sql.CreateCommand();
                    cmd.CommandText = "UPDATE  Items SET " + name + " = " + deger + " Where ItemID = '" + index + "'";
                    cmd.ExecuteNonQuery();
                    sql.Close();
                }
            
        }

        //Geçersiz değer girilirse hata mesajı verir
        private void dgvProducts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            var name = dgvProducts.Columns[columnIndex].DataPropertyName;
            e.Cancel = false;
            MessageBox.Show("Geçersiz bir değer girildi","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button3);
          
        }

       

        //ItemID değiştirilirse eski değerine döndürür
        private void dgvProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var name = dgvProducts.Columns[e.ColumnIndex].DataPropertyName;
            if (name == "ItemID")
            {
                var dataRow = ((DataRowView)dgvProducts.Rows[e.RowIndex].DataBoundItem).Row;
                dataRow.RejectChanges();
            }
           
        }

        private void ucProducts_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm erase?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ItemID"].Value.ToString());
                string sql = "Delete from Items Where ItemID='" + id + "'";
                if (Crud.ARU(sql))
                {
                    List();
                }
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTag_Click(object sender, EventArgs e)
        {
            txtTag.Text = string.Empty; 
        }
    }
}
