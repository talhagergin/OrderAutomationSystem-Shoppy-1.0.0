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
    public partial class PaymentCredit : Form
    {
        Order order;
        PictureBox selectedPicture;
        Dictionary<Credit.CardType, PictureBox> pictures = new Dictionary<Credit.CardType, PictureBox>();
        internal event callBack completed;
        public PaymentCredit()
        {
            InitializeComponent();
            selectedPicture = pictureAmericanEx;
            pictures.Add(Credit.CardType.Visa, pictureVisa);
            pictures.Add(Credit.CardType.MasterCard, pictureMaster);
            pictures.Add(Credit.CardType.JCB, pictureJCB);
            pictures.Add(Credit.CardType.Discover, pictureDiscover);
            pictures.Add(Credit.CardType.AmericanExpress, pictureAmericanEx);
            foreach(var item in pictures)
            {
                item.Value.Visible = false;
            }
            
        }
        internal void getOrder(Order order)
        {
            this.order = order;
            txtAmount.Text = order.Details.TotalAmount.ToString();
            txtAmount.Enabled = false;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Buy pf = Application.OpenForms["PaymentForm"] as Buy;
            pf.lblExit_Click(null, null);
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            ExpDate exp = new ExpDate();
            exp.month = cmbMonth.SelectedItem.ToString();
            exp.year = cmbYear.SelectedItem.ToString();
            Credit crdt = new Credit(Convert.ToInt32(txtAmount.Text), txtNumber.Text, exp);
            PaymentEvents pe = new PaymentEvents();
            pe.Completed = true;
            order.Details.Address = txtAdress.Text;
            crdt.Name = txtName.Text;
            crdt.Surname = txtSurname.Text;
            pe.Order = order;

            orderPayment op = new orderPayment();

            op.Show();


            this.completed(crdt, pe);

        }

        private void PaymentCredit_Load(object sender, EventArgs e)
        {

        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            selectedPicture.Visible = false;
            Credit.CardType type = Credit.getCardType(txtNumber.Text);
            if ( type != Credit.CardType.UnknownCard)
            {
                selectedPicture = pictures[type];
                selectedPicture.Visible = true;
            }
        }
    }
}
