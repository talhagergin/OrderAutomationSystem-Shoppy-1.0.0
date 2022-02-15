using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Text.RegularExpressions;
using System.Data.SQLite;
using System.Data;

namespace OrderAutomationSystem
{

    public partial class loginPanel : Form
    {
       bool splash = false;
        DataSet ds;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shoppy));
        SQLiteCommand cmd;
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
        Task t1;

        Image[] images = GetFramesFromAnimatedGIF(Image.FromFile(@".\Icons\totes.gif"));

        bool stopped = true;//Animasyon devam ederken programın bozulmasını engeller
        public loginPanel()
        {
            InitializeComponent();
            Init_Data();
            ds = new DataSet();
            cmd = new SQLiteCommand();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            bilgilendirmeLabel.Visible = false;
            loffButton.Visible = false;
        }
        ~loginPanel(){
            GC.Collect();

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
                    if (usernameBox.Width == 289)
                    {
                        break;
                    }

                    usernameBox.Width = usernameBox.Width + 3;
                    var locX = usernameBox.Location.X;
                    locX--;
                    usernameBox.Location = new Point(locX, usernameBox.Location.Y);
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
            if (splash)
                return;
            if (isRegister) { return; }
            clickedX = true;
            Task.Run(() =>
            {


                for (int i = 0; i < 16; i++)
                {
                    if (usernameBox.Width == 241)
                    {
                        break;
                    }
                    usernameBox.Width = usernameBox.Width - 3;
                    var locX = usernameBox.Location.X;
                    locX++;
                    if (splash)
                        return;
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
            if (splash)
                return;
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
                    if (splash)
                        return;
                    passwordBox.Location = new Point(locX, passwordBox.Location.Y);
                    if (splash)
                        return;
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
            if (passwordBox.PasswordChar == '*')
            {
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

            Save_Data();

            if (!isRegister)
            {
                /* DatabaseDataSetTableAdapters.CustomersTableAdapter a = new DatabaseDataSetTableAdapters.CustomersTableAdapter();
                 using(var sqlCheck = new SqlCommand("SELECT COUNT(*) FROM Customers WHERE ([Email] = '"+usernameBox.Text)){

                 }*/
                if (usernameBox.Text == string.Empty)
                {
                    return;
                }
                if (passwordBox.Text == string.Empty)
                {
                    return;
                }
                int ID;
                string name;
                string surname;
                string email;
                string address;
                int balance;
                string isAdmin;
                string pass;
                string IsVerified;
                string VerifyCode;
                int c;

                using (SQLiteConnection sql = new SQLiteConnection("Data source=.\\dataBase.db"))
                {
                    ds.Clear();
                    sql.Open();
                    cmd = sql.CreateCommand();
                    cmd.CommandText = @"SELECT * FROM Customers Where Email = '" + usernameBox.Text + "'";
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                    dataAdapter.Fill(ds);
                    c = ds.Tables[0].Rows.Count;
                    if (c == 0)
                    {
                        sql.Close();
                        return;
                    }

                    object[] dt = ds.Tables[0].Rows[0].ItemArray;
                    ID = Convert.ToInt32(dt[0]);
                    name = dt[1].ToString();
                    surname = dt[2].ToString();
                    email = dt[3].ToString();
                    address = dt[4].ToString();
                    pass = dt[5].ToString();
                    balance = Convert.ToInt32(dt[6]);
                    isAdmin = dt[8].ToString();
                    IsVerified = dt[9].ToString();
                    VerifyCode = dt[10].ToString();

                    sql.Close();

                }
                if (passwordBox.Text != pass)
                {
                    return;
                }
                if (isAdmin == "FALSE")
                {
                    Customers customer = new Customers(ID, email, name, surname, address, balance);
                    customer.setVerify(IsVerified, VerifyCode);
                    SplashScreen spsh = new SplashScreen(customer, false,isLight);
                    spsh.Show();
                    this.Dispose();

                }
                else
                {
                    splash = true;
                    Customers admin = new Customers(ID, email, name, surname, address, balance);
                    SplashScreen spsh = new SplashScreen(admin, true, isLight);
                    spsh.Show();
                    this.Dispose();
                }

            }
            else
            {
                if (t1 != null)
                {
                    if (!t1.IsCompleted)
                        return;
                }
                Guna.UI2.WinForms.Guna2TextBox emailB = this.Controls["emailRegister"] as Guna.UI2.WinForms.Guna2TextBox;
                Guna.UI2.WinForms.Guna2TextBox username1B = this.Controls["usernameRegister"] as Guna.UI2.WinForms.Guna2TextBox;
                Regex rEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (emailB != null)
                {
                    if (!rEmail.IsMatch(emailB.Text))
                    {
                        bilgilendirmeLabel.Visible = true;
                        t1 = new Task(() =>
                        {
                            var locX = bilgilendirmeLabel.Location.X - 55;
                            bilgilendirmeLabel.Location = new Point(locX, bilgilendirmeLabel.Location.Y);
                            bilgilendirmeLabel.ForeColor = Color.Red;
                            bilgilendirmeLabel.Text = "Email is not valid";
                            emailB.Text = string.Empty;
                            Titret();
                            Thread.Sleep(1000);
                            bilgilendirmeLabel.Visible = false;
                            locX = bilgilendirmeLabel.Location.X + 55;
                            bilgilendirmeLabel.Location = new Point(locX, bilgilendirmeLabel.Location.Y);
                        });
                        t1.Start();

                    }
                    else
                    {
                        if (username1B.Text == string.Empty)
                        {
                            bilgilendirmeLabel.Visible = true;
                            t1 = new Task(() =>
                            {
                                var locX = bilgilendirmeLabel.Location.X - 90;
                                bilgilendirmeLabel.Location = new Point(locX, bilgilendirmeLabel.Location.Y);
                                bilgilendirmeLabel.ForeColor = Color.Red;
                                bilgilendirmeLabel.Text = "Username can not be empty";
                                Titret();
                                Thread.Sleep(1000);
                                bilgilendirmeLabel.Visible = false;
                                locX = bilgilendirmeLabel.Location.X + 90;
                                bilgilendirmeLabel.Location = new Point(locX, bilgilendirmeLabel.Location.Y);
                            });
                            t1.Start();
                        }
                        else
                        {
                            Guna.UI2.WinForms.Guna2TextBox pass1B = this.Controls["usernameBox"] as Guna.UI2.WinForms.Guna2TextBox;
                            Guna.UI2.WinForms.Guna2TextBox pass2B = this.Controls["passwordBox"] as Guna.UI2.WinForms.Guna2TextBox;
                            string pass1 = pass1B.Text;
                            string pass2 = pass2B.Text;
                            if (pass1 == string.Empty)
                            {
                                bilgilendirmeLabel.Visible = true;
                                t1 = new Task(() =>
                                {
                                    var locX = bilgilendirmeLabel.Location.X - 90;
                                    bilgilendirmeLabel.Location = new Point(locX, bilgilendirmeLabel.Location.Y);
                                    bilgilendirmeLabel.ForeColor = Color.Red;
                                    bilgilendirmeLabel.Text = "Password can not be empty";
                                    Titret();
                                    Thread.Sleep(1000);
                                    bilgilendirmeLabel.Visible = false;
                                    locX = bilgilendirmeLabel.Location.X + 90;
                                    bilgilendirmeLabel.Location = new Point(locX, bilgilendirmeLabel.Location.Y);
                                });
                                t1.Start();
                            }
                            else
                            {

                                //TÜM İŞLEMLER YERİNE DOĞRU BİR ŞEKİLDE GETİRİLDİYSE ---------------------------------------------------
                                if (pass1 == pass2)
                                {
                                    int count = 0;
                                    using (SQLiteConnection sql = new SQLiteConnection("Data source=.\\dataBase.db"))
                                    {
                                        sql.Open();
                                        cmd = sql.CreateCommand();
                                        cmd.CommandText = @"SELECT * FROM Customers WHERE Email = '" + emailB.Text + "'";

                                        SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                                        dataAdapter.Fill(ds);
                                        DataTable dt = ds.Tables[0];
                                        count = dt.Rows.Count;
                                        sql.Close();



                                    }
                                    if (count > 0)
                                    {
                                        bilgilendirmeLabel.Visible = true;

                                        t1 = new Task(() =>
                                        {
                                            var locX = bilgilendirmeLabel.Location.X - 90;
                                            bilgilendirmeLabel.Location = new Point(locX, bilgilendirmeLabel.Location.Y);
                                            bilgilendirmeLabel.ForeColor = Color.Red;
                                            bilgilendirmeLabel.Text = "This email is already in use";
                                            Titret();
                                            Thread.Sleep(1000);
                                            bilgilendirmeLabel.Visible = false;
                                            locX = bilgilendirmeLabel.Location.X + 90;
                                            bilgilendirmeLabel.Location = new Point(locX, bilgilendirmeLabel.Location.Y);
                                        });
                                        t1.Start();
                                    }
                                    else
                                    {
                                        bilgilendirmeLabel.Visible = true;
                                        t1 = new Task(() =>
                                        {
                                            var locX = bilgilendirmeLabel.Location.X - 110;
                                            bilgilendirmeLabel.Location = new Point(locX, bilgilendirmeLabel.Location.Y);
                                            bilgilendirmeLabel.ForeColor = Color.Green;
                                            bilgilendirmeLabel.Text = "You have successfully registered!";
                                            Thread.Sleep(1500);
                                            bilgilendirmeLabel.Visible = false;
                                            locX = bilgilendirmeLabel.Location.X + 110;
                                            bilgilendirmeLabel.Location = new Point(locX, bilgilendirmeLabel.Location.Y);
                                        });
                                        t1.Start();
                                        InsertCustomer(username1B.Text, null, null, emailB.Text, pass1, -1, false);

                                        registerButton_Click(registerButton, null);
                                    }
                                }
                                else
                                {

                                    bilgilendirmeLabel.Visible = true;
                                    t1 = new Task(() =>
                                     {
                                         var locX = bilgilendirmeLabel.Location.X - 110;
                                         bilgilendirmeLabel.Location = new Point(locX, bilgilendirmeLabel.Location.Y);
                                         bilgilendirmeLabel.ForeColor = Color.Red;
                                         bilgilendirmeLabel.Text = "Confirm Password doen't match!";
                                         pass1B.Text = string.Empty;
                                         pass2B.Text = string.Empty;
                                         Titret();
                                         Thread.Sleep(1000);
                                         bilgilendirmeLabel.Visible = false;
                                         locX = bilgilendirmeLabel.Location.X + 110;
                                         bilgilendirmeLabel.Location = new Point(locX, bilgilendirmeLabel.Location.Y);
                                     });
                                    t1.Start();
                                }
                            }
                        }
                    }
                }
            }

        }

        private void Init_Data()
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    usernameBox.Text = Properties.Settings.Default.Username;
                    passwordBox.Text = Properties.Settings.Default.Password;
                    chcRememberMe.Checked = true;
                }
                else
                {
                    usernameBox.Text = Properties.Settings.Default.Username;

                }
            }
        }
        private void Save_Data()
        {
            if (chcRememberMe.Checked)
            {
                Properties.Settings.Default.Username = usernameBox.Text;
                Properties.Settings.Default.Password = passwordBox.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
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
                    double i = 1;
                    stopped = false;
                    while (!(pictureBox.Location.Y >= 63))
                    {


                        var locX = pictureBox.Location.X;
                        var locY = pictureBox.Location.Y + i;
                        i = i + 0.5;
                        pictureBox.Location = new Point((int)locX, (int)locY);
                        Thread.Sleep(5);
                    }
                    stopped = true;
                });
                isRegister = false;
                usernameBox.PasswordChar = '\0';
                char[] Register = { 'R', 'e', 'g', 'i', 's', 't', 'e', 'r' };
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
                    double i = 1;
                    stopped = false;
                    while (!(pictureBox.Location.Y <= 12))
                    {


                        var locX = pictureBox.Location.X;
                        var locY = pictureBox.Location.Y - i;
                        i = i + 0.5;
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
            if (isLight)
            {
                usernameRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));

            }
            else
            {
                usernameRegister.FillColor = Color.FromArgb(105, 105, 105);
            }
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
            if (isLight)
            {
                usernameRegister2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            }
            else
            {
                usernameRegister2.FillColor = Color.FromArgb(105, 105, 105);
            }
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
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Titret()
        {
            int titrett = 0;
            Random r = new Random();
            Point p = this.Location;

            while (titrett < 20)
            {
                int x = r.Next(1, 10);
                int y = r.Next(1, 10);

                this.Location = new Point(p.X + x, p.Y + y);
                Thread.Sleep(20);
                titrett++;
            }
        }

        private async void InsertCustomer(string Name, string Surname, string Address, string Email, string password, int OrderID, bool IsAdmin)
        {
            await Task.Run(() =>
            {
                using (SQLiteConnection sql = new SQLiteConnection("Data source=.\\dataBase.db"))
                {
                    sql.Open();
                    cmd = sql.CreateCommand();
                    cmd.CommandText = @"INSERT INTO Customers (Name, Email, Password) VALUES ('" + Name + "','" + Email + "','" + password + "')";
                    cmd.ExecuteNonQuery();
                    sql.Close();

                }
            });

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (isLight)
            {
                isLight = false;
                this.BackColor = Color.FromArgb(42, 42, 42);
                usernameBox.FillColor = Color.FromArgb(105, 105, 105);
                passwordBox.FillColor = Color.FromArgb(105, 105, 105);
                registerButton.FillColor = Color.DarkGray;
                registerButton.FillColor2 = Color.Black;
                loginButton.FillColor = Color.DarkGray;
                loginButton.FillColor2 = Color.Black;
                passButton.BackColor = Color.FromArgb(105, 105, 105);
                lightBtn.Visible = false;
                loffButton.Visible = true;
                if (!(this.Controls["usernameRegister"] is null))
                {
                    Guna.UI2.WinForms.Guna2TextBox tb = this.Controls["usernameRegister"] as Guna.UI2.WinForms.Guna2TextBox;
                    tb.FillColor = Color.FromArgb(105, 105, 105);
                }
                if (!(this.Controls["emailRegister"] is null))
                {
                    Guna.UI2.WinForms.Guna2TextBox tb = this.Controls["emailRegister"] as Guna.UI2.WinForms.Guna2TextBox;
                    tb.FillColor = Color.FromArgb(105, 105, 105);

                }

            }
            else
            {
                isLight = true;
                this.BackColor = Color.WhiteSmoke;
                registerButton.FillColor = Color.FromArgb(94, 148, 255);
                registerButton.FillColor2 = Color.FromArgb(255, 77, 165);
                loginButton.FillColor = Color.FromArgb(94, 148, 255);
                loginButton.FillColor2 = Color.FromArgb(255, 77, 165);
                usernameBox.FillColor = Color.FromArgb(137, 207, 240);
                passwordBox.FillColor = Color.FromArgb(137, 207, 240);
                passButton.BackColor = Color.FromArgb(137, 207, 240);
                lightBtn.Visible = true;
                loffButton.Visible = false;
                if (!(this.Controls["usernameRegister"] is null))
                {
                    Guna.UI2.WinForms.Guna2TextBox tb = this.Controls["usernameRegister"] as Guna.UI2.WinForms.Guna2TextBox;
                    tb.FillColor = Color.FromArgb(137, 207, 240);
                }
                if (!(this.Controls["emailRegister"] is null))
                {
                    Guna.UI2.WinForms.Guna2TextBox tb = this.Controls["emailRegister"] as Guna.UI2.WinForms.Guna2TextBox;
                    tb.FillColor = Color.FromArgb(137, 207, 240);

                }
            }
        }

        private void chcRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
