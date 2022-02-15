using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace OrderAutomationSystem
{
    public partial class SplashScreen : Form
    {
        bool isAdmin;
        Customers customer;
        bool isLight;
        List<string> texts = new List<string>();
        int selectedIndex = 1;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
       int l,
       int t,
       int r,
       int b,
       int a,
       int qw
           );
        PrivateFontCollection modernFont = new PrivateFontCollection();
        public SplashScreen()
        {
            InitializeComponent();
            modernFont.AddFontFile(@".\fnt\LEMONMILK-BoldItalic.otf");
            float size = 20F;
            desLabel.Font = new Font(modernFont.Families[0],size);
            texts.Add("We are working to improve\r\nyour experience\r\n");
            texts.Add("Get ready shopping on the\r\nInternet \r\n");
            texts.Add("Big discounts are coming \r\nsoon follow us \r\n");
            texts.Add("Be waiting for the new   \r\nupcomings!!!   \r\n");
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, Height, 10, 10));
            

        }
        public SplashScreen(Customers customer,bool isAdmin,bool isLight):this()
        {
            this.isAdmin = isAdmin;
            this.customer = customer;
            this.isLight = isLight;
        }
        

        private void checkBox_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

            /* 958   518*/
            Task.Run(() =>
            {
                for (int i = 0; i < 101; i++)
                {
                    progressBar.Value++;
                    Thread.Sleep(100);
                }


            }).ContinueWith((a) =>
            {
                BeginInvoke(new Action(() => {
                    if (!isAdmin)
                    {
                        customerMenu customermenu = new customerMenu(customer, isLight);
                        customermenu.Show();
                        this.Dispose();
                    }
                    else
                    {
                        Shoppy admin_menu = new Shoppy(customer, isLight);
                        admin_menu.Show();
                        this.Dispose();
                    }
                }));
               


            });
        }

        int i = 70;
        bool ters = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ters)
            {
                i = i - 5;
                if(i == 70)
                {
                    desLabel.ForeColor = Color.FromArgb(i, i, i);
                    ters = false;
                }
                else {
                    desLabel.ForeColor = Color.FromArgb(i, i, i);

                }

            }
            else {
                i = i + 5;
                if (i == 255)
                {
                    desLabel.ForeColor = Color.FromArgb(i, i, i);
                    ters = true;
                    selectedIndex++;
                    if(selectedIndex == texts.Count)
                    {
                        selectedIndex = 0;
                    }
                    desLabel.Text = texts[selectedIndex];
                }
                else
                {
                    desLabel.ForeColor = Color.FromArgb(i, i, i);
                }
            }
        }
    }
}
