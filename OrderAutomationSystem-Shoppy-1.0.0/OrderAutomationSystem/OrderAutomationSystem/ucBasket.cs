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
    public partial class ucBasket : UserControl
    {

        bool isStopped = true;
        Customers customer;
        public ucBasket()
        {
            InitializeComponent();
            //  ucItem.items; sepetteki itemleri çeker List şeklinde
            txtPrice.Enabled = false;
            txtName.Enabled = false;
            txtDescription.Enabled = false;
            lblLoading.Visible = false;

        }
        public ucBasket(Customers customers) : this()
        {
            this.customer = customers;
        }

        internal static void itemAdd(Item item)
        {
            ListBox list = (ListBox)customerMenu.userControls[2].Controls["panelBasket"].Controls["listBasket"];
            bool isExist = false;
            foreach(Item item2 in list.Items)
            {
                if(item2.ItemID == item.ItemID)
                {
                    isExist = true;
                }
            }
            if (!isExist)
            {
                list.Items.Add(item);
                Label lb = (Label)customerMenu.userControls[2].Controls["panelBasket"].Controls["groupBoxInfo"].Controls["lblCost2"];
                lb.Text = (Convert.ToInt32(lb.Text) + (item.Amount * item.Price)).ToString();
            }
        }

        internal static void itemRemove(Item item)
        {
            ListBox list = (ListBox)customerMenu.userControls[2].Controls["panelBasket"].Controls["listBasket"];
            Label lb = (Label)customerMenu.userControls[2].Controls["panelBasket"].Controls["groupBoxInfo"].Controls["lblCost2"];
            int indexof = 0;
            for(int i = 0; i < list.Items.Count; i++)
            {
                Item item2 = list.Items[i] as Item;
                if(item.ItemID == item2.ItemID)
                {
                    indexof = i;
                }
            }
            Item item3 = list.Items[indexof] as Item; 
            lb.Text = (Convert.ToInt32(lb.Text) - (item3.Amount * item3.Price)).ToString();
            list.Items.RemoveAt(indexof);
               

        }

        private void panelBasket_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void pay_Click(object sender, EventArgs e)
        {
            if (!isStopped)
                return;
            List<Item> items = new List<Item>();
            int calc = 0;
            foreach (Item item in listBasket.Items)
            {
                items.Add(item);
                calc = calc + item.Amount;
            }
            OrderDetail details = new OrderDetail();
            Order order = new Order();
            lblLoading.Visible = true;
            await Task.Run(() =>
            {
                lblLoading.Visible = true;
                details.setDetail(items, calc);
                order.setOrder(details);

            });
            bool verify = order.verifyInternet();
            if (verify)
            {

            }
            else
            {
                MessageBox.Show("There is no internet connection.(To see the remainder of the project, Application will keep continue.");
                order.Date = DateTime.Now;
            }
            lblLoading.Visible = false;
            Buy pf = new Buy(order);
            pf.completed += closed;
            pf.Show();

        }


        private void closed(object sender, PaymentEvents e)
        {
            isStopped = true;
            if (sender == null)
            {

            }
            else
            {
                Payment p = sender as Payment;
                string cmd = $"SELECT seq from sqlite_sequence where name = \"Orders\"";

                DataTable dt = Crud.List(cmd);
                object[] a =dt.Rows[0].ItemArray;
                int id = Convert.ToInt32(a[0]);
                if (id == -1)
                    id = 0;
                string sid = customer.CustomerID.ToString() +0.ToString()+ id.ToString();
                foreach (Item item in e.Order.Details.Items)
                {
                    cmd = $"INSERT INTO Orders (OrderIDs, ItemID, CustomerID, Quantity, Name, Surname, Address, Date, Status, TotalPrice) VALUES ('{sid}','{item.ItemID}','{customer.CustomerID}','{item.Amount}','{p.Name}','{p.Surname}','{e.Order.Details.Address}','{e.Order.Date}','{e.Order.State}','{e.Order.Details.TotalAmount}')";
                    Crud.ARU(cmd);

                    
                    

                }
                     dt.Clear();
                    string cmd2 = $"SELECT OrderIDs,Name,Surname,Quantity,TotalPrice,Date,Address,Status From Orders WHERE OrderIDS GLOB '{customer.CustomerID}*'";
                    dt = Crud.List(cmd2);
                ucHome profil = customerMenu.userControls[0] as ucHome;
                DataGridView dtt = profil.Controls["dtOrders"] as DataGridView;
                dtt.DataSource = dt;
                ucProfil home = customerMenu.userControls[1] as ucProfil;
                ucProfil.removeAll();
                home.btnSearch_Click(null, null);
                listBasket.Items.Clear();
                txtName.Clear();
                txtPrice.Clear();
                txtDescription.Clear();
                txtQuantitity.SelectedIndex = 0;
                lblCost2.Text = "0";
                if (customer.IsVerified != "FALSE")
                {
                    Email.sendOrder(customer.Email, e.Order);
                }
                

            }
        }
        private void listBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtName.Text = listBasket.SelectedItem.ToString();
            ListBox lbox = sender as ListBox;
            Item U1 = lbox.SelectedItem as Item;
            if (U1 == null)
                return;
            txtName.Text = U1.Name;
            txtQuantitity.SelectedIndex = txtQuantitity.FindStringExact((U1.Amount).ToString());
            txtPrice.Text = (U1.Price * Convert.ToInt32(txtQuantitity.Text)).ToString();
            txtDescription.Text = U1.Description;
        }
        private void enabledColor(object sender, EventArgs e)
        {

            Guna.UI2.WinForms.Guna2TextBox box = sender as Guna.UI2.WinForms.Guna2TextBox;
            box.ForeColor = Color.FromArgb(125, 137, 149);
            box.FillColor = Color.White;


        }
        private void enabledColor_Paint(object sender, PaintEventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox box = sender as Guna.UI2.WinForms.Guna2TextBox;

        }


        private void txtQuantitity_SelectedIndexChanged(object sender, EventArgs e)
        {

            Item U1 = listBasket.SelectedItem as Item;
            if (U1 == null)
                return;
            U1.Amount = Convert.ToInt32(txtQuantitity.Text);
            if (!(U1 is null))
                txtPrice.Text = (U1.Price * Convert.ToInt32(txtQuantitity.Text)).ToString();
            int total = 0;
            foreach (Item item in listBasket.Items)
            {
                total = total + item.Amount * item.Price;
            }
            lblCost2.Text = total.ToString();

        }

        private void ucBasket_Load(object sender, EventArgs e)
        {

        }
    }
}