using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace MasaustuneCentik
{
    public partial class frmCentik : Form
    {
        public frmCentik()
        {
            InitializeComponent();
        }
        int indir = 60;
        int kaldir = 0;
        int CalistiMi = 0;
        int ekranortala = Screen.PrimaryScreen.Bounds.Width / 2 - 180;
        private void frmCentik_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - 180, Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.Bounds.Height - indir);
            tmrSaat.Start();

           
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
            if (InternetKontrol() == true)
            {
                pnlInternet.BackgroundImage = Image.FromFile(@"intvar.png");
                
            }
            else
            {
                pnlInternet.BackgroundImage = Image.FromFile(@"intyok.png");
            }
        }

        private void frmCentik_MouseHover(object sender, EventArgs e)
        {
            tmrIndir.Start();
            CalistiMi = 0;
        }

        private void lblSaat_MouseHover(object sender, EventArgs e)
        {
            tmrIndir.Start();
            HaberlerSlider();
        }

        private void frmCentik_MouseLeave(object sender, EventArgs e)
        {
            tmrKaldir.Start();
            CalistiMi = 10;
        }

        private void tmrIndir_Tick(object sender, EventArgs e)
        {
            if (CalistiMi == 0)
            {
                if (indir == 60 || indir != 0)
                {
                    indir--;
                    ekranortala = Screen.PrimaryScreen.Bounds.Width / 2 - 180;
                }
                else
                {
                    Baricikart();
                    tmrIndir.Stop();
                }
                this.Location = new Point(ekranortala, Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.Bounds.Height - indir);
            }
            else
            {
                CalistiMi = 0;
                indir = 60;
                tmrIndir.Start();
            }
        }

        private void tmrKaldir_Tick(object sender, EventArgs e)
        {
            kaldir = 60;
            this.Width = 360;

            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - 180, Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.Bounds.Height - kaldir);
            tmrKaldir.Stop();
        }

        private void lblHaber_MouseLeave(object sender, EventArgs e)
        {
            tmrKaldir.Start();
            CalistiMi = 10;
        }

        private void Baricikart()
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            ekranortala = 0;
            this.Location = new Point(0);
        }

        private void HaberlerSlider()
        {
            Uri urlhaber = new Uri("https://www.trthaber.com/sitene-ekle/gundem-1/?haberSay=30");
            WebClient clienthaber = new WebClient();

            string htmlhaber = clienthaber.DownloadString(urlhaber);
            HtmlAgilityPack.HtmlDocument dokumanhaber = new HtmlAgilityPack.HtmlDocument();
            dokumanhaber.LoadHtml(htmlhaber);
            tmrHaber.Enabled = true;
            

            for (int i = 1; i < 30; i++)
            {
                string haberler = dokumanhaber.DocumentNode.SelectNodes("/html/body/div/a[" + i.ToString() + "]/span[1]")[0].InnerText.Replace("quot;", "");
                byte[] bytes = Encoding.Default.GetBytes(haberler);
                string falan = Encoding.UTF8.GetString(bytes);
                lblHaber.Text += falan + " // ";

            }
        }

        private void tmrHaber_Tick(object sender, EventArgs e)
        {
            lblHaber.Text = lblHaber.Text.Substring(1) + lblHaber.Text.Substring(0, 1);

            lblHaber.Text = lblHaber.Text.Substring(1) + lblHaber.Text.Substring(0, 1);
        }
        public bool InternetKontrol()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
        }
    }
}
