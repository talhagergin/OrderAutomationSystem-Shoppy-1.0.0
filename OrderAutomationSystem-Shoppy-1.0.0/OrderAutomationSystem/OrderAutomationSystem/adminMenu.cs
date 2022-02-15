using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SQLite;

namespace OrderAutomationSystem
{
    public partial class Shoppy : Form
    {
        Customers customer;
        
        bool isLight = false;
        Task t1;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int l,
        int t,
        int r,
        int b,
        int a,
        int qw
            );
        ucStatistics ucStatistics1;
        ucProducts ucProducts1;
        ucEmployees ucEmployees1;
        ucCustomers ucCustomers1;
        UserControl[] menus = new UserControl[4];
        public Shoppy()
        {
            InitializeComponent();
            /*this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));*/
            loffBtn.Location = lightBtn.Location;
            ucStatistics1 = new ucStatistics();
            ucProducts1 = new ucProducts();
            ucEmployees1 = new ucEmployees();
            ucCustomers1 = new ucCustomers();
            
            menus[0] = ucStatistics1;
            menus[1] = ucProducts1;
            menus[2] = ucCustomers1;
            menus[3] = ucEmployees1;
            foreach(UserControl c in menus)
            {
                c.Location = new Point(227, 65);
                this.Controls.Add(c);
            }
            
           

        }
        public Shoppy(Customers customer,bool isLight) : this()
        {
            this.customer = customer;
            lblUserName.Text = customer.Name;
            

            
            this.isLight = isLight;
            lightBtn_Click(null,null);                                     
        }
        private void adminMenu_Load(object sender, EventArgs e)
        {
            ucStatistics1.Visible = true;
            ucStatistics1.BringToFront();   
            ucProducts1.Hide();
            ucCustomers1.Hide();
            ucEmployees1.Hide();


        }
        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pctMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pctMaximize.Visible = false;
            pctRestore.Visible = true;
        }
        private void pctRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pctRestore.Visible = false;
            pctMaximize.Visible = true;
        }

        private void pctMenuSideBar_Click(object sender, EventArgs e)
        {
            if (!(t1 is null))
            {
                if (!t1.IsCompleted || !AnimationSidebar.IsCompleted || !AnimatiomSidebarBack.IsCompleted)
                    return;
            }

            if (gunaMenuBar.Width == 200)
            {
                gunaMenuBar.Visible = false;
                btnEmployees.Text = string.Empty;
                t1 = new Task(() =>
                {
                    int i = 200;
                    int t = 300;
                    int b = 240;
                    this.BeginInvoke(new Action(() =>
                    {
                        while (i != 65)
                        {
                            i = i - 9;
                            t = t - 14;
                            b = b - 13;
                            gunaMenuBar.Width = i;
                            sidebarWrapper.Width = t;
                            ucStatistics1.Location = new Point((t + 14), 80);
                            ucProducts1.Location = new Point((t + 14), 80);
                            ucCustomers1.Location = new Point((t + 14), 80);
                            ucEmployees1.Location = new Point((t + 14), 80);

                            pnlLine.Width = b;
                            System.Threading.Thread.Sleep(5);
                        }
                    }));
                });
                t1.Start();
                AnimationSidebar.Show(gunaMenuBar);
            }
            else
            {
                gunaMenuBar.Visible = false;
                btnEmployees.Text = "Personnels";
                t1 = new Task(() =>
                {
                    int i = 65;
                    int t = 90;
                    int b = 45;
                    this.BeginInvoke(new Action(() =>
                    {
                        while (i != 200)
                        {
                            i = i + 9;
                            t = t + 9;
                            b = b - 13;
                            sidebarWrapper.Width = t;
                            gunaMenuBar.Width = i;
                            ucStatistics1.Location = new Point(t, 80);
                            ucProducts1.Location = new Point(t, 80);
                            ucCustomers1.Location = new Point(t, 80);
                            ucEmployees1.Location = new Point(t, 80);

                            pnlLine.Width = b;
                            System.Threading.Thread.Sleep(5);
                        }
                    }));
                });
                t1.Start();
                t1.ContinueWith((t) =>
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        pnlLine.Width = 180;

                    }));
                });
                AnimatiomSidebarBack.Show(gunaMenuBar);
            }
        }

        private void lightBtn_Click(object sender, EventArgs e)
        {
            if (!isLight)//aydinlik mod
            {
                isLight = true;
                loffBtn.Visible = true;
                lightBtn.Visible = false;

                extButton2.Visible = true;//kapalı modda kapalı olucak
                menuTop.BackColor = Color.FromArgb(224, 224, 224);
                sidebarWrapper.BackColor = Color.FromArgb(240, 240, 240);
                this.BackColor = Color.White;

                gunaMenuBar.FillColor = Color.FromArgb(66, 204, 255);
                gunaMenuBar.FillColor2 = Color.FromArgb(66, 204, 255);

                btnDashboard.ForeColor = Color.WhiteSmoke;
                btnEmployees.ForeColor = Color.WhiteSmoke;
                btnProducts.ForeColor = Color.WhiteSmoke;
                btnCustomers.ForeColor = Color.WhiteSmoke;
                lblMenuName.ForeColor = Color.FromArgb(127, 131, 134);
                lblUserName.ForeColor = Color.FromArgb(127, 131, 134);

                ucStatistics1.BackColor = Color.White;
                foreach (var item in ucStatistics1.Controls)
                {
                    if (item is Label)
                    {
                        Label lblStatistics = item as Label;
                        lblStatistics.ForeColor = Color.FromArgb(66, 244, 255);
                    }
                }
                ucProducts1.BackColor = Color.White;
                foreach (var item in ucProducts1.Controls)
                {
                    if (item is Label)
                    {
                        Label lblProducts = item as Label;
                        lblProducts.ForeColor = Color.FromArgb(66, 244, 255);
                    }
                    else if (item is Guna.UI2.WinForms.Guna2TextBox)
                    {
                        Guna.UI2.WinForms.Guna2TextBox gunaTxtProduct = item as Guna.UI2.WinForms.Guna2TextBox;
                        gunaTxtProduct.FillColor = Color.FromArgb(137, 207, 240);
                        gunaTxtProduct.PlaceholderForeColor = Color.FromArgb(127, 131, 134);
                        gunaTxtProduct.ForeColor = Color.DodgerBlue;
                    }
                    else if (item is Guna.UI2.WinForms.Guna2GradientButton)
                    {
                        Guna.UI2.WinForms.Guna2GradientButton gunaBtnProduct = item as Guna.UI2.WinForms.Guna2GradientButton;
                        gunaBtnProduct.FillColor = Color.FromArgb(94, 148, 255);
                        gunaBtnProduct.FillColor2= Color.FromArgb(255, 77, 165);
                    }
                }
                ucCustomers1.BackColor = Color.White;
                foreach (var item in ucCustomers1.Controls)
                {
                    if (item is Label)
                    {
                        Label lblCustomers = item as Label;
                        lblCustomers.ForeColor = Color.FromArgb(66, 244, 255);
                    }

                    else if (item is Guna.UI2.WinForms.Guna2TextBox)
                    {
                        Guna.UI2.WinForms.Guna2TextBox gunaTxtCustomers = item as Guna.UI2.WinForms.Guna2TextBox;
                        gunaTxtCustomers.FillColor = Color.FromArgb(137, 207, 240);
                        gunaTxtCustomers.PlaceholderForeColor = Color.FromArgb(127, 131, 134);
                        gunaTxtCustomers.ForeColor = Color.DodgerBlue;
                    }
                    else if (item is Guna.UI2.WinForms.Guna2GradientButton)
                    {
                        Guna.UI2.WinForms.Guna2GradientButton gunaBtnCustomers = item as Guna.UI2.WinForms.Guna2GradientButton;
                        gunaBtnCustomers.FillColor = Color.FromArgb(94, 148, 255);
                        gunaBtnCustomers.FillColor2 = Color.FromArgb(255, 77, 165);
                    }
                }
                ucEmployees1.BackColor = Color.White;
                foreach (var item in ucEmployees1.Controls)
                {
                    if (item is Label)
                    {
                        Label lblEmployees = item as Label;
                        lblEmployees.ForeColor = Color.FromArgb(66, 244, 255);
                    }
                    else if (item is Guna.UI2.WinForms.Guna2TextBox)
                    {
                        Guna.UI2.WinForms.Guna2TextBox gunaTxtEmployees= item as Guna.UI2.WinForms.Guna2TextBox;
                        gunaTxtEmployees.FillColor = Color.FromArgb(137, 207, 240);
                        gunaTxtEmployees.PlaceholderForeColor = Color.FromArgb(127, 131, 134);
                        gunaTxtEmployees.ForeColor = Color.DodgerBlue;
                    }
                    else if (item is Guna.UI2.WinForms.Guna2GradientButton)
                    {
                        Guna.UI2.WinForms.Guna2GradientButton gunaBtnPEmployees = item as Guna.UI2.WinForms.Guna2GradientButton;
                        gunaBtnPEmployees.FillColor = Color.FromArgb(94, 148, 255);
                        gunaBtnPEmployees.FillColor2 = Color.FromArgb(255, 77, 165);
                    }
                }
            }
            else
            {
                isLight = false;
                loffBtn.Visible = false;
                lightBtn.Visible = true;

                extButton2.Visible = false;//kapalı modda kapalı olucak
                menuTop.BackColor = Color.FromArgb(20, 20, 35);
                sidebarWrapper.BackColor = Color.FromArgb(30, 30, 48);
                this.BackColor = Color.FromArgb(30, 30, 48);

                gunaMenuBar.FillColor = Color.FromArgb(30, 30, 48);
                gunaMenuBar.FillColor2 = Color.FromArgb(165, 21, 80);

                btnDashboard.ForeColor = Color.White;
                btnEmployees.ForeColor = Color.White;
                btnProducts.ForeColor = Color.White;
                btnCustomers.ForeColor = Color.White;
                lblMenuName.ForeColor = Color.White;
                lblUserName.ForeColor = Color.White;

                ucStatistics1.BackColor = Color.FromArgb(30, 30, 48);
                foreach (var item in ucStatistics1.Controls)
                {
                    if (item is Label)
                    {
                        Label lblStatistics = item as Label;
                        lblStatistics.ForeColor = Color.White;
                    }
                }
                ucProducts1.BackColor = Color.FromArgb(30, 30, 48);
                foreach (var item in ucProducts1.Controls)
                {
                    if (item is Label)
                    {
                        Label lblProducts = item as Label;
                        lblProducts.ForeColor = Color.White;
                    }
                    else if (item is Guna.UI2.WinForms.Guna2TextBox)
                    {
                        Guna.UI2.WinForms.Guna2TextBox gunaTxtProducts2 = item as Guna.UI2.WinForms.Guna2TextBox;
                        gunaTxtProducts2.FillColor = Color.White;
                        gunaTxtProducts2.PlaceholderForeColor = Color.FromArgb(193,200,207 );
                        gunaTxtProducts2.ForeColor = Color.FromArgb(125,137,149);
                    }
                    else if (item is Guna.UI2.WinForms.Guna2GradientButton)
                    {
                        Guna.UI2.WinForms.Guna2GradientButton gunaBtnProducts2 = item as Guna.UI2.WinForms.Guna2GradientButton;
                        gunaBtnProducts2.FillColor = Color.FromArgb(94, 148, 255);
                        gunaBtnProducts2.FillColor2 = Color.FromArgb(94, 148, 255);
                    }
                }
                ucCustomers1.BackColor = Color.FromArgb(30, 30, 48);
                foreach (var item in ucCustomers1.Controls)
                {
                    if (item is Label)
                    {
                        Label lblCustomers = item as Label;
                        lblCustomers.ForeColor = Color.White;
                    }
                    else if (item is Guna.UI2.WinForms.Guna2TextBox)
                    {
                        Guna.UI2.WinForms.Guna2TextBox gunaTxtCustomers2 = item as Guna.UI2.WinForms.Guna2TextBox;
                        gunaTxtCustomers2.FillColor = Color.White;
                        gunaTxtCustomers2.PlaceholderForeColor = Color.FromArgb(193, 200, 207);
                        gunaTxtCustomers2.ForeColor = Color.FromArgb(125, 137, 149);
                    }
                    else if (item is Guna.UI2.WinForms.Guna2GradientButton)
                    {
                        Guna.UI2.WinForms.Guna2GradientButton gunaBtnCustomers2 = item as Guna.UI2.WinForms.Guna2GradientButton;
                        gunaBtnCustomers2.FillColor = Color.FromArgb(94, 148, 255);
                        gunaBtnCustomers2.FillColor2 = Color.FromArgb(94, 148, 255);
                    }
                }
                ucEmployees1.BackColor = Color.FromArgb(30, 30, 48);
                foreach (var item in ucEmployees1.Controls)
                {
                    if (item is Label)
                    {
                        Label lblEmployees = item as Label;
                        lblEmployees.ForeColor = Color.White;
                    }
                    else if (item is Guna.UI2.WinForms.Guna2TextBox)
                    {
                        Guna.UI2.WinForms.Guna2TextBox gunaTxtEmployess2 = item as Guna.UI2.WinForms.Guna2TextBox;
                        gunaTxtEmployess2.FillColor = Color.White;
                        gunaTxtEmployess2.PlaceholderForeColor = Color.FromArgb(193, 200, 207);
                        gunaTxtEmployess2.ForeColor = Color.FromArgb(125, 137, 149);
                    }
                    else if (item is Guna.UI2.WinForms.Guna2GradientButton)
                    {
                        Guna.UI2.WinForms.Guna2GradientButton guneBtnEmployees2 = item as Guna.UI2.WinForms.Guna2GradientButton;
                        guneBtnEmployees2.FillColor = Color.FromArgb(94, 148, 255);
                        guneBtnEmployees2.FillColor2 = Color.FromArgb(94, 148, 255);
                    }
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblMenuName.Text = "Statistics";
            ucStatistics1.Show();
            ucStatistics1.BringToFront();
            ucProducts1.Hide();
            ucCustomers1.Hide();
            ucEmployees1.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            lblMenuName.Text = "Products";
            ucProducts1.Show();
            ucProducts1.BringToFront();
            ucStatistics1.Hide();
            ucCustomers1.Hide();
            ucEmployees1.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            lblMenuName.Text = "Customers";
            ucCustomers1.Show();
            ucCustomers1.BringToFront();
            ucStatistics1.Hide();
            ucProducts1.Hide();
            ucEmployees1.Hide();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            lblMenuName.Text = "Employees";
            ucEmployees1.Show();
            ucEmployees1.BringToFront();
            ucStatistics1.Hide();
            ucProducts1.Hide();
            ucCustomers1.Hide();
        }
    }
}
