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
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;


namespace Modern_Dashboard_Design
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=FURKAN\\SQLEXPRESS;Initial Catalog = Kasa; Integrated Security = True");

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
     (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
         int nHeightEllipse

      );

        public Form1()
        {
            InitializeComponent();

            timer1.Start();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            
            lblTitle.Text = "Ana Sayfa";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
        private int KasaHesapla()
        {
            int kasa = 0;
            int giris = 0;
            int cikis = 0;
            con.Open();
            SqlCommand cmdgiris = new SqlCommand("Select SUM(miktar) FROM GirisTable", con);
            SqlCommand cmdcikis = new SqlCommand("Select SUM(miktar) FROM CikisTable", con);
            if (cmdgiris.ExecuteScalar() != DBNull.Value)
            {
                giris += Convert.ToInt32(cmdgiris.ExecuteScalar());
            }
            if (cmdcikis.ExecuteScalar() != DBNull.Value)
            {
                cikis += Convert.ToInt32(cmdcikis.ExecuteScalar());
            }
            if (cmdgiris.ExecuteScalar() != DBNull.Value && cmdcikis.ExecuteScalar() != DBNull.Value)
            {
                kasa += Convert.ToInt32(cmdgiris.ExecuteScalar());
                kasa -= Convert.ToInt32(cmdcikis.ExecuteScalar());
            }
            con.Close();
            return kasa;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Ana Sayfa";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);
                
            lblTitle.Text = "Fiş Ekle";
            this.PnlFormLoader.Controls.Clear();
            frmAnalytics FrmDashboard_Vrb = new frmAnalytics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void BtnCalander_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalander.Height;
            pnlNav.Top = btnCalander.Top;
            btnCalander.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Tüm İşlemler";
            this.PnlFormLoader.Controls.Clear();
            frmCalander FrmDashboard_Vrb = new frmCalander() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnCalander_Leave(object sender, EventArgs e)
        {
            btnCalander.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int toplamTutar = KasaHesapla();
            con.Open();
            SqlCommand cmdkasa = new SqlCommand("INSERT INTO KasaTable (tutar) VALUES (@tutar)", con);
            cmdkasa.Parameters.AddWithValue("@tutar", toplamTutar);
            cmdkasa.ExecuteNonQuery();
            con.Close();
            Application.Exit();
        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label2.Text = now.ToString("dd/MM/yyyy HH:mm");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKisi_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnKisi.Height;
            pnlNav.Top = btnKisi.Top;
            btnKisi.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Kişi Bilgisi";
            this.PnlFormLoader.Controls.Clear();
            frmKisi FrmDashboard_Vrb = new frmKisi() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
        private void btnKisi_Leave_1(object sender, EventArgs e)
        {
            btnKisi.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
