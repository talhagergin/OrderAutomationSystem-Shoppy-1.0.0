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
using System.Drawing.Text;

namespace OrderAutomationSystem
{
    public partial class customerMenu : Form
    {
        enum Radio
        {
            KralFM,
            BestFM,
            AlemFM,
            None
        };

        Dictionary<Radio, string> radioURL = new Dictionary<Radio, string>();
        Radio selectedFM = Radio.None;
        PictureBox selectedPicture;


        PrivateFontCollection modernFont = new PrivateFontCollection();
        bool isLight = false;

        private int formKoor, formKoorX, formKoorY;

        Timer t1 = new Timer();                   //
        Timer t2 = new Timer();                   // Yandan çıkan kutucuk için altta regionda yazılı
        static Guna.UI2.WinForms.Guna2Panel popup;//
        Guna.UI2.WinForms.Guna2PictureBox selectedBtn;//Alttaki butonlardaki seçili butonu tutar
        Customers customer;                         //Profil için customer
        UserControl selectedControl;                    //
        public static UserControl[] userControls = new UserControl[3];// Alttaki butonlardan sonra çılan usercontrolleri tutar soldan sağa doğru 0 1 2


        public customerMenu()
        {
       
            radioURL.Add(Radio.KralFM, @"http://46.20.3.204/");
            radioURL.Add(Radio.BestFM, @"http://46.20.7.126/");
            radioURL.Add(Radio.AlemFM, @"https://turkmedya.radyotvonline.com/turkmedya/alemfm.stream/playlist.m3u8");
            InitializeComponent();
            mediaPlayer.settings.volume = 0;
            pictureAlemFM.Visible = false;
            selectedPicture = pictureAlemFM;
            pictureBestFM.Visible = false;
            pictureKralFM.Visible = false;
            selectedBtn = userBtn2;
            marketBtn2.Visible = false;
            homeBtn2.Visible = false;
            t1.Interval = 2;
            t1.Tick += new EventHandler(Tick);
            t2.Interval = 1000;
            t2.Tick += new EventHandler(Tick2);
            modernFont.AddFontFile(@".\fnt\Winter Sunday.ttf");
            lblName.Font = new Font(modernFont.Families[0], 25F);
        }

      

        public customerMenu(Customers customer) : this()
        {

            this.customer = customer;
            ucHome profil = new ucHome(customer);//
            ucProfil home = new ucProfil();
            ucBasket basket = new ucBasket(customer);                                 //
                                                                                      //

            profil.Location = new Point(125, 64);//
            profil.Size = new Size(1049, 559);
            profil.Visible = true;              // ilk seçili butonlar forumn altındaki 2 ile bitenler beyaz olur seçilmiş anlamına gelir 1 le bitenler normal
            home.Location = new Point(125, 64);  //
            home.Size = new Size(1049, 559);
            home.Visible = false;               //
            basket.Location = new Point(125, 64);
            basket.Size= new Size(1049, 559);
            basket.Visible = false;
            this.Controls.Add(profil);          //
            this.Controls.Add(home);
            this.Controls.Add(basket);                                 //
            selectedControl = profil;           //        SEPET USER CONTROLÜNÜN POİNTİ VİSİBLİTİSİ AYARLANCAK ONDAN SONRA THİS.CONTROLS E VE
            userControls[0] = profil;           //       
            userControls[1] = home;
            userControls[2] = basket;     //        userControls[2] ye eklenicek

        }
        public customerMenu(Customers customer, bool isLight) : this(customer)
        {

            this.isLight = isLight;
            if (!isLight) { loffBtn_Click(null, null); loffBtn.Visible = false;lightBtn.Visible = true; }
            else {  lightBtn_Click(null, null); loffBtn.Visible = true; lightBtn.Visible = false; }
           
        }


        private void marketBtn_Click(object sender, EventArgs e)//Sepet butonuna basılırsa sağdaki       SEPET AÇILDIĞINDA selectedControl.Visib
        {
            selectedControl.Visible = false;
            selectedControl = userControls[2];
            selectedControl.Visible = true;
            selectedBtn.Visible = false;
            selectedBtn = marketBtn2;
            marketBtn2.Visible = true;

        }

        private void userBtn_Click(object sender, EventArgs e)//profil butonuna basılırsa soldaki
        {
            selectedControl.Visible = false;
            selectedControl = userControls[0];
            selectedControl.Visible = true;
            selectedBtn.Visible = false;
            selectedBtn = userBtn2;
            userBtn2.Visible = true;
        }

        private void homeBtn_Click(object sender, EventArgs e)//market butonuna basılırsa ortadaki buton
        {
            selectedControl.Visible = false;
            selectedControl = userControls[1];
            selectedControl.Visible = true;
            selectedBtn.Visible = false;
            selectedBtn = homeBtn2;
            homeBtn2.Visible = true;
        }

        private void ucHome1_Load(object sender, EventArgs e)
        {

        }

        private void customerMenu_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }


        //Yandan çıkıcak kutucuk--------------------------------
        #region  ınfokutucugu
        internal static void InfoPopup(string Name, bool b)
        {
            customerMenu cm = Application.OpenForms["customerMenu"] as customerMenu;
            if (popup != null)
            {
                cm.Controls.Remove(popup);
                popup.Dispose();
                popup = null;
                cm.AnimationPopup2();


            }
            Label labelInfo = new Label();
            Guna.UI2.WinForms.Guna2Panel panelInfo = new Guna.UI2.WinForms.Guna2Panel();
            panelInfo.FillColor = System.Drawing.Color.DodgerBlue;
            panelInfo.Location = new System.Drawing.Point(1255, 637);
            panelInfo.Name = "panelInfo";
            panelInfo.ShadowDecoration.Parent = panelInfo;
            panelInfo.Size = new System.Drawing.Size(147, 75);
            panelInfo.BorderRadius = 10;
            panelInfo.TabIndex = 6;
            //Label Info
            labelInfo.AutoSize = true;
            labelInfo.BackColor = System.Drawing.Color.Transparent;
            labelInfo.ForeColor = Color.WhiteSmoke;
            labelInfo.Location = new System.Drawing.Point(10, 7);
            labelInfo.Name = "labelInfo";
            labelInfo.Parent = panelInfo;
            labelInfo.Size = new System.Drawing.Size(35, 13);
            labelInfo.TabIndex = 0;
            labelInfo.Font = new Font("Microsoft Sans Serif", 9F);
            if (b)
            {
                labelInfo.Text = $"{Name} \nsepete eklendi";
            }
            else
            {
                labelInfo.Text = $"{Name} \nsepetten çıkarıldı";

            }
            popup = panelInfo;
            cm.Controls.Add(popup);
            cm.AnimationPopup(popup);
        }
        private void AnimationPopup(Guna.UI2.WinForms.Guna2Panel panelInfo)
        {
            t1.Start();
        }
        private void AnimationPopup2()
        {
            t2.Stop();
            t2.Start();
        }
        private void Tick(object sender, EventArgs e)
        {

            popup.Location = new Point(popup.Location.X - 25, popup.Location.Y);
            if (popup.Location.X == 1005)
            {
                t1.Stop();
                t2.Start();

            }
        }
        private void Tick2(object sender, EventArgs e)
        {
            t2.Stop();
            popup.Dispose();
        }


        #endregion

        private void marketBtn2_Click(object sender, EventArgs e)
        {

        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            formKoor = 1;
            formKoorX = e.X;
            formKoorY = e.Y;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lightBtn_Click(object sender, EventArgs e)
        {
            isLight = true;
            if (isLight)//aydinlik mod
            {

                loffBtn.Visible = true;
                lightBtn.Visible = false;

                

                panelMove.BackColor = Color.FromArgb(224,224,224);
                this.BackColor = Color.White;

                pnlRadio.BackColor = this.BackColor;
                pnlRadio.BorderColor = Color.FromArgb(224, 224, 224);
                iconPlay.IconColor = Color.DodgerBlue;
                iconSkip.IconColor = Color.DodgerBlue;
                iconSkip.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
                iconPlay.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
                iconPlay.BackColor = this.BackColor;
                iconSkip.BackColor = this.BackColor;

                foreach (var control in userControls)
                {
                    UserControl ucform = control as UserControl;
                    ucform.BackColor = Color.WhiteSmoke;

                    foreach (var item in control.Controls)
                    {
                        if (item is Label)
                        {
                            Label lbl = item as Label;
                            lbl.ForeColor = Color.DodgerBlue;
                        }
                        else if (item is DataGridView)
                        {
                            DataGridView dt = item as DataGridView;
                            dt.BackgroundColor = Color.White;
                        }
                        else if (item is GroupBox)
                        {
                            GroupBox grb = item as GroupBox;
                            grb.ForeColor = Color.DodgerBlue;
                        }

                        else if (item is Panel)
                        {
                            Panel pnl = item as Panel;
                            pnl.BackColor = Color.FromArgb(137, 207, 240);
                            foreach (var item2 in pnl.Controls)
                            {
                                if (item2 is GroupBox)
                                {
                                    GroupBox grp = item2 as GroupBox;
                                    grp.BackColor = Color.FromArgb(137, 207, 240);
                                    grp.ForeColor = Color.DodgerBlue;
                                }
                            }
                        }

                    }
                }
            }
            
        }

        private void loffBtn_Click(object sender, EventArgs e)
        {
            isLight = false;
            if(!isLight)
            {
                loffBtn.Visible = false;
                lightBtn.Visible = true;

                panelMove.BackColor = Color.FromArgb(22, 30, 40);
                this.BackColor = Color.FromArgb(30, 41, 55);

                pnlRadio.BorderColor = Color.FromArgb(22, 30, 40);
                pnlRadio.BackColor = this.BackColor;
                iconPlay.IconColor = Color.DodgerBlue;
                iconSkip.IconColor = Color.DodgerBlue;
                iconSkip.FlatAppearance.BorderColor = Color.FromArgb(25, 37, 48);
                iconPlay.FlatAppearance.BorderColor = Color.FromArgb(25, 37, 48);
                iconPlay.BackColor = this.BackColor;
                iconSkip.BackColor = this.BackColor;

                foreach (var control in userControls)
                {
                    UserControl ucform = control as UserControl;
                    ucform.BackColor = Color.FromArgb(35, 41, 55);

                    foreach (var item in control.Controls)
                    {
                        if (item is Label)
                        {
                            Label lbl = item as Label;
                            lbl.ForeColor = Color.White;
                        }
                        else if(item is DataGridView)
                        {
                            DataGridView dt = item as DataGridView;
                            dt.BackgroundColor = Color.FromArgb(30, 41, 55);
                        }
                        else if (item is GroupBox)
                        {
                            GroupBox grb = item as GroupBox;
                            grb.ForeColor = Color.Black;
                        }

                        else if (item is Panel)
                        {
                            Panel pnl = item as Panel;
                            pnl.BackColor = Color.SteelBlue;
                            foreach (var item2 in pnl.Controls)
                            {
                                if (item2 is GroupBox)
                                {
                                    GroupBox grp = item2 as GroupBox;
                                    grp.BackColor = Color.SteelBlue;
                                    grp.ForeColor = Color.Black;
                                }
                            }
                        }

                    }
                }
            }
        }

        private void ıconPlay_Click(object sender, EventArgs e)
        {
           FontAwesome.Sharp.IconButton btn = sender as FontAwesome.Sharp.IconButton;
            if(btn.IconChar == FontAwesome.Sharp.IconChar.PlayCircle)
            {
                btn.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
                mediaPlayer.Ctlcontrols.play();
            }
            else
            {
                btn.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
                mediaPlayer.Ctlcontrols.pause();
                
            }
        }

        private void iconSkip_Click(object sender, EventArgs e)
        {
            
            if (selectedFM == Radio.None)
            {
                selectedFM = Radio.AlemFM;
                mediaPlayer.URL = radioURL[selectedFM];
                selectedPicture.Visible = false;
                selectedPicture = pictureAlemFM;
                selectedPicture.Visible = true;
            }
            else if (selectedFM == Radio.AlemFM)
            {
                selectedFM = Radio.BestFM;
                mediaPlayer.URL = radioURL[selectedFM];
                selectedPicture.Visible = false;
                selectedPicture = pictureBestFM;
                selectedPicture.Visible = true;
            }
            else if (selectedFM == Radio.BestFM)
            {
                selectedFM = Radio.KralFM;
                mediaPlayer.URL = radioURL[selectedFM];
                selectedPicture.Visible = false;
                selectedPicture = pictureKralFM;
                selectedPicture.Visible = true;
            }
            else
            {
                selectedFM = Radio.AlemFM;
                mediaPlayer.URL = radioURL[selectedFM];
                selectedPicture.Visible = false;
                selectedPicture = pictureAlemFM;
                selectedPicture.Visible = true;
            }
        }

        private void radioTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2VTrackBar track = sender as Guna.UI2.WinForms.Guna2VTrackBar;
            mediaPlayer.settings.volume = 100 - track.Value;
        }

        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (formKoor == 1)
            {
                this.SetDesktopLocation(MousePosition.X - formKoorX, MousePosition.Y - formKoorY);
            }
        }

        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            formKoor = 0;
        }
    }


}
