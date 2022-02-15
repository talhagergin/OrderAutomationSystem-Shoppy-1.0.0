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
    public partial class ucEmployees : UserControl
    {
        int? id = null;
        public bool save = false;
        SQLiteCommand cmd;
        DataSet ds = new DataSet();

        BindingSource bd = new BindingSource();
        public ucEmployees()
        {
            
            InitializeComponent();
           
            
            using (SQLiteConnection sql = new SQLiteConnection("Data source=.\\dataBase.db"))
            {
              
               
                sql.Open();
                cmd = sql.CreateCommand();
                cmd.CommandText = @"SELECT Name,Surname,Email,Address FROM Customers WHERE IsAdmin != 'FALSE'";
                SQLiteCommand cmd2 = sql.CreateCommand();
                cmd2.CommandText = @"SELECT Name,Surname,Email,Address FROM Employee";

                

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                dataAdapter.Fill(ds);
                dataAdapter = new SQLiteDataAdapter(cmd2);
                dataAdapter.Fill(ds);
                sql.Close();
            }
            
            bd.DataSource = ds.Tables[0];
            dgvEmployees.DataSource = bd;
        }



        private void txtEmployeeSearch_Click(object sender, EventArgs e)
        {
            txtEmployeeSearch.Text = string.Empty;
        }
        public ucEmployees(int? Id = null) : this()
        {

            List();
            if (Id != null)
                this.id = Id;
        }

        void List()
        {
            string sql = "Select * from Customers";
            dgvEmployees.DataSource = Crud.List(sql);
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmployees_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
