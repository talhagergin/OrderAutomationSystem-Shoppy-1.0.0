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
    public partial class ucItem : UserControl
    {
       
        public Item item;
        public ucItem()
        {
            InitializeComponent();
        }
        public ucItem(Item item) : this()
        {
            this.item = item;
            lblName.Text = item.Name;
            lblPrice.Text = item.Price.ToString();     
            pictureBox.BackgroundImage = item.Picture;
            pictureBox.Image = item.Picture;
            pictureBox.BringToFront();
    
            checkedBox.Visible = false;
            

        }
        public void disable()
        {
            if (checkedBox.Visible == true)
            {
                ucBasket.itemRemove(this.item);
            }
            this.Dispose();
        }

       
        private void mainPanel_Click(object sender, EventArgs e)
        {
           
            checkedBox.Visible = !checkedBox.Visible;
            if (checkedBox.Visible)
            {
                string name = checkedBox.Parent.Controls["lblName"].Text;
                customerMenu.InfoPopup(name, true);

                ucBasket.itemAdd(item);
                ucProfil.items.Add(item.ItemID);
                
            }
            else
            {
                string name = checkedBox.Parent.Controls["lblName"].Text;
                customerMenu.InfoPopup(name, false);
                ucBasket.itemRemove(item);
                ucProfil.items.Remove(item.ItemID);

            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            checkedBox.Visible = !checkedBox.Visible;
            if (checkedBox.Visible)
            {
                string name = checkedBox.Parent.Controls["lblName"].Text;
                customerMenu.InfoPopup(name, true);
                ucBasket.itemAdd(item);
                ucProfil.items.Add(item.ItemID);

            }
            else
            {
                string name = checkedBox.Parent.Controls["lblName"].Text;
                customerMenu.InfoPopup(name, false);
                ucBasket.itemRemove(item);
                ucProfil.items.Remove(item.ItemID);

            }

        }

        private void ucItem_Load(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
