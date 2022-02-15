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
using System.IO;

namespace OrderAutomationSystem
{
    public partial class ucProfil : UserControl
    {
        //Home kısmı
        DataSet ds;
        public static List<int> items = new List<int>();
        public ucProfil()
        {
            InitializeComponent();
            ds = new DataSet();
            using (SQLiteConnection sql = new SQLiteConnection("Data source=.\\dataBase.db"))
            {
                sql.Open();
                SQLiteCommand cmd = sql.CreateCommand();
                cmd.CommandText = "SELECT * FROM Items";
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                dataAdapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                sql.Close();
            }
        }
        //Item değeri atancak
        
        public static void removeAll()
        {
            items.Clear();

        }
        internal void btnSearch_Click(object sender, EventArgs e)
        {
            itemPanel.AutoScroll = false;
            int countof = itemPanel.Controls.Count;
            for (int i = 0; i < countof; i++)
            {
                if(itemPanel.Controls[i] is ucItem)
                {
                    itemPanel.Controls.RemoveAt(i);
                    countof--;
                    i--;
                }
            }
            
            
           int startX = 15;
            int startY = 15;
            if (txtSearch.Text == string.Empty)
            {
                
                DataTable dt = ds.Tables[0];
                int count = ds.Tables[0].Rows.Count;  

                for (int i = 0; i < count; i++)
                {
                    object[] list = dt.Rows[i].ItemArray;
                    
                    Item item = new Item(Convert.ToInt32(list[0]), list[1].ToString(), Convert.ToInt32(list[2]), Convert.ToInt32(list[3]), list[4].ToString(), Convert.ToInt32(list[5]), list[6].ToString());
                    
                    
                    item.Picture = Base64ToImage(list[7].ToString());
                    ucItem ucitem = new ucItem(item);
                    if (startX <= 615)
                    {
                        ucitem.Location = new Point(startX, startY);
                        startX = startX + 300;
                    }
                    else
                    {
                        startX = 15;
                        startY = startY + 231;
                        ucitem.Location = new Point(startX, startY);
                        startX = startX + 300;
                    }
                    itemPanel.Font = new Font("Microsoft Sans Serif", 8.25F);
                    itemPanel.Controls.Add(ucitem);
                    if (items.Contains(item.ItemID))
                    {
                        ucitem.Controls["mainPanel"].Controls["checkedBox"].Visible = true;
                        ucBasket.itemAdd(item);
                    }
                }
            }
            else
            {
                DataTable dt = ds.Tables[0];
                int count = ds.Tables[0].Rows.Count;
                var dr =  ds.Tables[0].AsEnumerable().Where(s => s.Field<string>("Name") == txtSearch.Text || s.Field<string>("Tag") == txtSearch.Text).ToList<object>();
                
                    foreach (var item in dr)
                    {
                    DataRow drrr = item as DataRow;
                    object[] myItem = drrr.ItemArray;
                    
                        Item item2 = new Item(Convert.ToInt32(myItem[0]), myItem[1].ToString(), Convert.ToInt32(myItem[2]), Convert.ToInt32(myItem[3]), myItem[4].ToString(), Convert.ToInt32(myItem[5]), myItem[6].ToString());
                    item2.Picture = Base64ToImage(myItem[7].ToString());

                    ucItem ucitem = new ucItem(item2);
                        if (startX <= 615)
                        {
                            ucitem.Location = new Point(startX, startY);
                            startX = startX + 300;
                        }
                        else
                        {
                            startX = 15;
                            startY = startY + 231;
                            ucitem.Location = new Point(startX, startY);
                        }
                        itemPanel.Font = new Font("Microsoft Sans Serif", 8.25F);
                        itemPanel.Controls.Add(ucitem);
                    if (items.Contains(item2.ItemID))
                    {
                        ucitem.Controls["mainPanel"].Controls["checkedBox"].Visible = true;
                        ucBasket.itemAdd(item2);
                    }
                    }
                
            }

            itemPanel.AutoScroll = true;
        }

        private void ucProfil_Load(object sender, EventArgs e)
        {

        }
        public Image Base64ToImage(string base64String)
        {
            if (base64String == "NULL" || base64String == string.Empty)
                return null;
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);

            return image;
        }
    }
}
