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
    public partial class ucCustomers : UserControl
    {
        int? id = null;
        public bool save = false;
        SQLiteCommand cmd;
        DataSet ds = new DataSet();

        BindingSource bd = new BindingSource();
        public ucCustomers()
        {
            InitializeComponent();
            using (SQLiteConnection sql = new SQLiteConnection("Data source=.\\dataBase.db"))
            {
                sql.Open();
                cmd = sql.CreateCommand();
                cmd.CommandText = @"SELECT  OrderIDs,ItemID,CustomerID,Quantity,Name,Surname,Address,Date,Status,TotalPrice FROM Orders ";

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                dataAdapter.Fill(ds);
                sql.Close();
            }
            bd.DataSource = ds.Tables[0];
            dgvCustomers.DataSource = bd;
        }

    
        public ucCustomers(int? Id = null) : this()
        {

            List();
            if (Id != null)
                this.id = Id;
        }

        void List()
        {
            string sql = "Select * from Orders";
            dgvCustomers.DataSource = Crud.List(sql);
        }

        private void ucCustomers_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
