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
{   internal delegate void callBack(object sender, PaymentEvents e);

    public partial class Buy : Form
    {
        internal event callBack completed;
        Order order;
        PaymentCredit credit = new PaymentCredit();
        PaymentCheck check = new PaymentCheck();
        PaymentCash cash = new PaymentCash();
        public Buy()
        {
            InitializeComponent();
            credit.completed += lblExit_Click;
            check.completed += lblExit_Click;
            cash.completed += lblExit_Click;
        }
        internal Buy(Order order) : this()
        {
            this.order = order;
            credit.getOrder(order);
            check.getOrder(order);
            cash.getOrder(order);

        }


        internal void lblExit_Click(object sender, EventArgs e)
        {
            
           

            
            /*else
            {
                PaymentEvents pa = new PaymentEvents();
                pa.Completed = true;
                OrderDetail detail = new OrderDetail(null, 0);
                pa.Order = new Order(detail);
                if (completed != null)
                    completed(null, pa);
            }*/
            credit.Dispose();
            check.Dispose();
            cash.Dispose();
            this.Dispose();
            if(sender is Payment)
            {
                PaymentEvents pe = e as PaymentEvents;
                pe.Completed = true;
                completed(sender as Payment, pe);
            }
            else
            {               

               completed(null, null);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            credit.Left += 10;
            if (credit.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                credit.TopMost = true;
                timer2.Start();
            }
        }
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            credit.Left -= 10;
            if (credit.Left <= 679)
            {
                timer1.Stop();
                this.TopMost = false;
                credit.TopMost = true;
                timer2.Stop();
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            credit.ShowInTaskbar = false;
            credit.Show();
            check.ShowInTaskbar = false;
            check.Show();
            cash.ShowInTaskbar = false;
            cash.Show();
        }

        private void pnlCredit_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pnlCheck_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            check.Left += 10;
            if (check.Left >= 830)
            {
                timer3.Stop();
                this.TopMost = false;
                check.TopMost = true;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            check.Left -= 10;
            if (check.Left <= 679)
            {
                timer3.Stop();
                this.TopMost = false;
                check.TopMost = true;
                timer4.Stop();
            }
        }

        private void pnlCash_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            cash.Left += 10;
            if (cash.Left >= 830)
            {
                timer5.Stop();
                this.TopMost = false;
                cash.TopMost = true;
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            cash.Left -= 10;
            if (cash.Left <= 679)
            {
                timer5.Stop();
                this.TopMost = false;
                cash.TopMost = true;
                timer6.Stop();
            }   
        }
    }
}
