using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAutomationSystem
{
    public partial class ucHome : UserControl
    {
        Customers customer;
        public static DataTable dt;
        public ucHome()
        {
            InitializeComponent();
        }
        public ucHome(Customers customer) : this()
        {
            this.customer = customer;
            txtName.Text = customer.Name;
            txtSurname.Text = customer.Surname;
            txtAddress.Text = customer.Address;
            txtEmail.Text = customer.Email;
            if(customer.IsVerified == "TRUE")
            {
                txtVerify.Dispose();
                btnVerify.Dispose();
            }
            string cmd = $"SELECT OrderIDs,Name,Surname,Quantity,TotalPrice,Date,Address,Status From Orders WHERE OrderIDS GLOB '{customer.CustomerID}*'";
            dt = Crud.List(cmd);
            dtOrders.DataSource = dt;
        }

        private void ucHome_Load(object sender, EventArgs e)
        {

        }

        private void ucHome_MouseMove(object sender, MouseEventArgs e)
        {
          

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cmd = $"UPDATE Customers SET Name = \"{txtName.Text}\", Surname = \"{txtSurname.Text}\", Address = \"{txtAddress.Text}\" WHERE CustomerID = {this.customer.CustomerID}";
            Crud.ARU(cmd);

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(customer.VerifyCode == "FALSE")
            {
                Random rnd = new Random();
                int m = rnd.Next(1, 13);
                int dice = rnd.Next(1, 7);
                int card = rnd.Next(52);
                string code = "CDS" + m + dice + card;
                bool isSended = Email.sendVerify(customer.Email,code);
                if (isSended)
                {
                    customer.VerifyCode = code;
                    string cmd = $"UPDATE Customers SET VerifyCode = \"{code}\" WHERE CustomerID = {customer.CustomerID}";
                    Crud.ARU(cmd);
                }
                else
                {
                    MessageBox.Show("An unexpected error occurred. Please check your connection to internet", "Unexpected Error");
                }

            }
            else
            {
                if(customer.VerifyCode == txtVerify.Text)
                {
                    MessageBox.Show("Your email has been verified successfully", "Verified");
                    txtVerify.Visible = false;
                    txtVerify.Dispose();
                    btnVerify.Visible = false;
                    btnVerify.Dispose();    
                    customer.IsVerified = "TRUE";

                    string cmd = $"UPDATE Customers SET IsVerified = \"{customer.IsVerified}\" WHERE CustomerID = {customer.CustomerID}";
                    Crud.ARU(cmd);
                }
                else
                {
                    MessageBox.Show("Verify code doesn't match up", "Doesn't Match Up");
                }
            }
        }
    }
    
    
}
