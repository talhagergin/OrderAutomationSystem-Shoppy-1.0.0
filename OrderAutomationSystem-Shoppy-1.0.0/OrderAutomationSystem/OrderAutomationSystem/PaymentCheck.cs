using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAutomationSystem
{
    public partial class PaymentCheck : Form
    {
        internal event callBack completed;
        Order order;
        public PaymentCheck()
        {
            InitializeComponent();
        }



        private void lblExit_Click(object sender, EventArgs e)
        {
            Buy pf = Application.OpenForms["PaymentForm"] as Buy;
            pf.lblExit_Click(null, null);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Check chck = new Check(Convert.ToInt32(txtAmount.Text), Convert.ToInt32(txtBankID.Text), txtName.Text, txtSurname.Text);
            order.Details.Address = txtAdress.Text;
            PaymentEvents pe = new PaymentEvents();
            pe.Completed = true;
            pe.Order = order;

            orderPayment op = new orderPayment();
            op.Show();
            this.completed(chck, pe);

        }
        internal void getOrder(Order order)
        {
            this.order = order;
            txtAmount.Text = order.Details.TotalAmount.ToString();
            txtAmount.Enabled = false;
        }
    }
}
