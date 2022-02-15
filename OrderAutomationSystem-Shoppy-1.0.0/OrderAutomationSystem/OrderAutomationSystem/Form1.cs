using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
    namespace OrderAutomationSystem
{

    public partial class loginPanel : Form
    {
        private bool clickedX = false;
        private bool clickedY = false;
        private bool isRegister = false;
        private bool isLight = true;
        //Dll ekleme yeri köşeleri yuvarlaklaştırmak için
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int l,
        int t,
        int r,
        int b,
        int a,
        int qw
            );


        Image[] images = GetFramesFromAnimatedGIF(Image.FromFile(@".\Icons\totes.gif"));

        bool stopped = true;//Animasyon devam ederken programın bozulmasını engeller
        public loginPanel()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Timer startalması loading ekranı
        private void loginPanel_Load(object sender, EventArgs e)
        {
            //ASYNC ANİMASYON U ÖNEMSİZ KALSIN 
            /*  
           Task.Run(() =>
            {
                while (!stopped)
                {
                    for(int i = 0; i < images.Length; i++)
                    {
                        pictureBox.Image = images[i];
                        System.Threading.Thread.Sleep(50);
                    }
                }
            });*/
            timer1.Start();


        }
        //Gifi Framelerine böler üst tarafta gifi hızlandırmak için kullandım
        public static Image[] GetFramesFromAnimatedGIF(Image IMG)
        {
            List<Image> IMGs = new List<Image>();
            int Length = IMG.GetFrameCount(FrameDimension.Time);

            for (int i = 0; i < Length; i++)
            {
                IMG.SelectActiveFrame(FrameDimension.Time, i);
                IMGs.Add(new Bitmap(IMG));
            }

            return IMGs.ToArray();
        }
        //Mouse Hareketleri Form haraket ettirilmesi
        #region HareketEttirilme
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void loginPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;

        }
        private void loginPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void loginPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion
        


        #region butonAnimasyonu
        private void usernameBox_Enter(object sender, EventArgs e)
        {
            if (isRegister) { return; }
            clickedX = false;
            Task.Run(() =>
            {
                
                
                    for (int i = 0; i < 16; i++)
                    {
                    if(usernameBox.Width == 289)
                    {
                        break;
                    }
                    
                        usernameBox.Width = usernameBox.Width+3;
                    var locX = usernameBox.Location.X;
                    locX--;
                    usernameBox.Location = new Point(locX,usernameBox.Location.Y);
                        Thread.Sleep(2);
                    if (clickedX)
                    {
                        break;
                    }
                    }
                
            });
            
        }

        private void usernameBox_Leave(object sender, EventArgs e)
        {
            if (isRegister) { return; }
            clickedX = true;
            Task.Run(() =>
            {


                for (int i = 0; i < 16; i++)
                {
                    if(usernameBox.Width == 241)
                    {
                        break;
                    }
                    usernameBox.Width = usernameBox.Width-3;
                    var locX = usernameBox.Location.X;
                    locX++;
                    usernameBox.Location = new Point(locX, usernameBox.Location.Y);
                    Thread.Sleep(2);
                    if (!clickedX)
                    {
                        break;
                    }
                }
                

            });
           

           

        }
        //Pasword butonun animasyonu

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            if (isRegister) { return; }
            clickedY = false;
            Task.Run(() =>
            {


                for (int i = 0; i < 16; i++)
                {
                    if (passwordBox.Width == 289)
                    {
                        break;
                    }

                    passwordBox.Width = passwordBox.Width + 3;
                    var locX = passwordBox.Location.X;
                    locX--;
                    var locX2 = passButton.Location.X;
                    locX2 = locX2 + 2;
                    passwordBox.Location = new Point(locX, passwordBox.Location.Y);
                    passButton.Location = new Point(locX2, passButton.Location.Y);
                    Thread.Sleep(2);
                    if (clickedY)
                    {
                        break;
                    }
                }

            });

        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (isRegister) { return; }
            clickedY = true;
            Task.Run(() =>
            {


                for (int i = 0; i < 16; i++)
                {
                    if (passwordBox.Width == 241)
                    {
                        break;
                    }
                    passwordBox.Width = passwordBox.Width - 3;
                    var locX = passwordBox.Location.X;
                    locX++;
                    var locX2 = passButton.Location.X;
                    locX2 = locX2 - 2;
                    passwordBox.Location = new Point(locX, passwordBox.Location.Y);
                    passButton.Location = new Point(locX2, passButton.Location.Y);
                    Thread.Sleep(2);
                    if (!clickedY)
                    {
                        break;
                    }
                }


            });

        }
        #endregion
        //Şifreyi görünür yapma
        private void passButton_Click(object sender, EventArgs e)
        {
            if(passwordBox.PasswordChar == '*') {
                if (isRegister)
                {
                    passwordBox.PasswordChar = '\0';
                    passButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                    usernameBox.PasswordChar = '\0';
                    
                }
                else
                {

                    passwordBox.PasswordChar = '\0';
                    passButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                }

            }
            else
            {
                if (isRegister)
                {
                    passwordBox.PasswordChar = '*';
                    passButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    usernameBox.PasswordChar = '*';
                }
                else
                {
                    passwordBox.PasswordChar = '*';
                    passButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
                }
                
            }
            
        }

        //Timer versiyon animasyon
        int timer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer = timer % images.Length;
            pictureBox.Image = images[timer];
            timer++;
        }


        //Login BUTONU KODLANCAK CONFİRM AYNI ZAMANDA isRegister bool değişkeni ile register ekranındamı değilmi algılanıyor ona göre yapılcak -------------------
        /* Register ekranında Username textbox name i usernameRegister
            Email textboxu emailRegister
            İlk password textboxu usernameBox
            İkinci password textboxu passwordBox
            
            Login ekranında Email yerniin name i usernameBox
            Password yerinin name i passwordBox
            
            isRegister = false ise login ekranındadır bu yüzden if(!isRegister){       } ile login  ekranındaki yerlerin kodu yazılacak else{} içine de register ekranındaki kodlar
            yazılacak
            
            örnek : 
            
            if(!isRegister){
            //Some codes for logginnig process .....
            }else{
            
            //Some codes for registering process .....
            }
        
        */

        private void loginButton_Click(object sender, EventArgs e)
        {
        }
        //----------------------------------------------------------------------------------------------------

        //Register ekranına giriş ve çıkış isRegister bool değişkeni ile algılanıyor
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!stopped)
                return;
            if (isRegister)
            {
                this.Controls["usernameRegister"].Dispose();
                this.Controls["emailRegister"].Dispose();
                usernameBox.Text = string.Empty;
                passwordBox.Text = string.Empty;
                usernameBox.PlaceholderText = "Email";
                Task.Run(() =>
                {
                    stopped = false;
                    while (!(pictureBox.Location.Y >= 63))
                    {

                        
                        var locX = pictureBox.Location.X;
                        var locY = pictureBox.Location.Y + 1;
                        pictureBox.Location = new Point((int)locX, (int)locY);
                        Thread.Sleep(5);
                    }
                    stopped = true;
                });
                isRegister = false;
                usernameBox.PasswordChar = '\0';
                char[] Register = { 'R', 'e', 'g', 'i','s','t','e','r' };
                char[] Login = { 'L', 'o', 'g', 'i', 'n' };
                Task.Run(() =>
                {
                    StringBuilder sbB = new StringBuilder();
                    StringBuilder sbC = new StringBuilder();
                    for (int i = 0; i < Register.Length; i++)
                    {

                        if (i < Login.Length)
                        {
                            sbB.Append(Login[i]);
                        }
                        sbC.Append(Register[i]);
                        registerButton.Text = sbC.ToString();
                        loginButton.Text = sbB.ToString();
                        Thread.Sleep(100);
                    }

                    
                });

            }
            else
            {
                isRegister = true;
                usernameBox.Text = string.Empty;
                passwordBox.Text = string.Empty;
                usernameBox.PasswordChar = passwordBox.PasswordChar;
                char[] Back = { 'B', 'a', 'c', 'k' };
                char[] Confirm = { 'C', 'o', 'n', 'f', 'i', 'r', 'm' };
                Task.Run(() =>
                {
                    stopped = false;
                    while (!(pictureBox.Location.Y <= 12))
                    {


                        var locX = pictureBox.Location.X;
                        var locY = pictureBox.Location.Y - 0.9;
                        pictureBox.Location = new Point((int)locX, (int)locY);
                        Thread.Sleep(5);
                    }
                    this.BeginInvoke(new Action(() =>
                    {
                        List<Guna.UI2.WinForms.Guna2TextBox> usernameRegisters = UsernameRegister();
                        foreach (var item in usernameRegisters)
                        {
                            Controls.Add(item);
                        }
                        usernameBox.PlaceholderText = "Password";



                    }));
                    stopped = true;
                });

                Task.Run(() =>
                {
                    StringBuilder sbB = new StringBuilder();
                    StringBuilder sbC = new StringBuilder();
                    for (int i = 0; i < Confirm.Length; i++)
                    {

                        if (i < Back.Length)
                        {
                            sbB.Append(Back[i]);
                        }
                        sbC.Append(Confirm[i]);
                        registerButton.Text = sbB.ToString();
                        loginButton.Text = sbC.ToString();
                        Thread.Sleep(100);
                    }


                });


            }
        }


        //Register Ekranındaki butonları oluşturur.
        #region ButonOluştur
        private List<Guna.UI2.WinForms.Guna2TextBox> UsernameRegister()
        {   
            Guna.UI2.WinForms.Guna2TextBox usernameRegister = new Guna.UI2.WinForms.Guna2TextBox();
            usernameRegister.BorderRadius = 23;
            usernameRegister.BorderThickness = 0;
            usernameRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            usernameRegister.DefaultText = "";
            usernameRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            usernameRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            usernameRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            usernameRegister.DisabledState.Parent = usernameRegister;
            usernameRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            usernameRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            usernameRegister.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            usernameRegister.FocusedState.Parent = usernameRegister;
            usernameRegister.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            usernameRegister.ForeColor = System.Drawing.Color.DodgerBlue;
            usernameRegister.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            usernameRegister.HoverState.Parent = usernameRegister;
            usernameRegister.Location = new System.Drawing.Point(142, 341);
            usernameRegister.Name = "usernameRegister";
            usernameRegister.PasswordChar = '\0';
            usernameRegister.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(134)))));
            usernameRegister.PlaceholderText = "Username";
            usernameRegister.SelectedText = "";
            usernameRegister.ShadowDecoration.Parent = usernameRegister;
            usernameRegister.Size = new System.Drawing.Size(241, 45);
            usernameRegister.TabIndex = 1;
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------
            Guna.UI2.WinForms.Guna2TextBox usernameRegister2 = new Guna.UI2.WinForms.Guna2TextBox();
            usernameRegister2.BorderRadius = 23;
            usernameRegister2.BorderThickness = 0;
            usernameRegister2.Cursor = System.Windows.Forms.Cursors.IBeam;
            usernameRegister2.DefaultText = "";
            usernameRegister2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            usernameRegister2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            usernameRegister2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            usernameRegister2.DisabledState.Parent = usernameRegister2;
            usernameRegister2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            usernameRegister2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            usernameRegister2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            usernameRegister2.FocusedState.Parent = usernameRegister2;
            usernameRegister2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            usernameRegister2.ForeColor = System.Drawing.Color.DodgerBlue;
            usernameRegister2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            usernameRegister2.HoverState.Parent = usernameRegister2;
            usernameRegister2.Location = new System.Drawing.Point(142, 271);
            usernameRegister2.Name = "emailRegister";
            usernameRegister2.PasswordChar = '\0';
            usernameRegister2.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(134)))));
            usernameRegister2.PlaceholderText = "Email";
            usernameRegister2.SelectedText = "";
            usernameRegister2.ShadowDecoration.Parent = usernameRegister2;
            usernameRegister2.Size = new System.Drawing.Size(241, 45);
            usernameRegister2.TabIndex = 0;
            List<Guna.UI2.WinForms.Guna2TextBox> texts = new List<Guna.UI2.WinForms.Guna2TextBox>();
            texts.Add(usernameRegister);
            texts.Add(usernameRegister2);
            return texts;

    }


        #endregion

        //Formu kapatma butonu
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
