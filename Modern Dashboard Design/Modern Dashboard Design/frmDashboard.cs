using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Modern_Dashboard_Design
{
    public partial class frmDashboard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=FURKAN\\SQLEXPRESS;Initial Catalog = Kasa; Integrated Security = True");
        public int a = 0;
        public frmDashboard()
        {
            InitializeComponent();
            VerileriGoster();
            DataDesign();
            KasaHesapla();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void VerileriGoster()
        {

            con.Open();
            string sqlQueryGiris = "SELECT * FROM GirisTable WHERE CAST (tarih AS DATE) = CAST (GETDATE() AS DATE)";
            SqlDataAdapter adapterGiris = new SqlDataAdapter(sqlQueryGiris, con);
            DataTable dataTableGiris = new DataTable();
            adapterGiris.Fill(dataTableGiris);
            dataGridView1.DataSource = dataTableGiris;
            dataGridView1.Sort(dataGridView1.Columns["tarihDataGridViewTextBoxColumn"], ListSortDirection.Descending);

            string sqlQueryCikis = "SELECT * FROM CikisTable WHERE CAST (tarih AS DATE) = CAST (GETDATE() AS DATE)";
            SqlDataAdapter adapterCikis = new SqlDataAdapter(sqlQueryCikis, con);
            DataTable dataTableCikis = new DataTable();
            adapterCikis.Fill(dataTableCikis);
            dataGridView2.DataSource = dataTableCikis;
            dataGridView2.Sort(dataGridView2.Columns["tarihDataGridViewTextBoxColumn1"], ListSortDirection.Descending);
            con.Close();
        }
        private int KasaHesapla()
        {
            int kasa = 0;
            int giris = 0;
            int cikis = 0;
            DateTime today = DateTime.Now;
            DateTime startTime = today.Date;
            DateTime endTime= today.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

            con.Open();
            SqlCommand cmdgiris = new SqlCommand("Select SUM(miktar) FROM GirisTable WHERE tarih BETWEEN @StartDate AND @EndDate" , con);
            SqlCommand cmdcikis = new SqlCommand("Select SUM(miktar) FROM CikisTable WHERE tarih BETWEEN @StartDate AND @EndDate" , con);
            SqlCommand cmdgiristoplam = new SqlCommand("Select SUM(miktar) FROM GirisTable", con);
            SqlCommand cmdcikistoplam = new SqlCommand("Select SUM(miktar) FROM CikisTable", con);
            cmdgiris.Parameters.AddWithValue("@StartDate", startTime);
            cmdgiris.Parameters.AddWithValue("@EndDate", endTime);
            cmdcikis.Parameters.AddWithValue("@StartDate", startTime);
            cmdcikis.Parameters.AddWithValue("@EndDate", endTime);

            if(cmdgiris.ExecuteScalar() != DBNull.Value)
            {
                giris += Convert.ToInt32(cmdgiris.ExecuteScalar());
            }
            //günlük kasa girişinin noktalanması


            if (giris >=0 && giris < 1000)
            {
                kasaGiris_lbl.Text = giris.ToString() + " TL";
            }
            else if(giris >=1000 && giris < 10000)
            {
                kasaGiris_lbl.Text = giris.ToString()[0] + "." + giris.ToString().Substring(1) + " TL";

            }
            else if(giris >= 10000 && giris < 100000)
            {
                kasaGiris_lbl.Text = giris.ToString().Substring(0,2) + "." + giris.ToString().Substring(2) + " TL";
            }
            else if(giris >=100000 && giris < 1000000)
            {
                kasaGiris_lbl.Text = giris.ToString().Substring(0, 3) + "." + giris.ToString().Substring(3) + " TL";
            }
            else if (giris >= 1000000 && giris < 10000000)
            {
                kasaGiris_lbl.Text = giris.ToString()[0] + "." + giris.ToString().Substring(1,3) + "." + giris.ToString().Substring(4, 3) + " TL";
            }
            else
            {
                kasaGiris_lbl.Text = giris.ToString() + " TL";
            }

            if (cmdcikis.ExecuteScalar() != DBNull.Value)
            {
                cikis += Convert.ToInt32(cmdcikis.ExecuteScalar());
            }
            //günlük kasa çıkışının noktalanması
            if (cikis >= 0 && cikis < 1000)
            {
                kasaCikis_lbl.Text = cikis.ToString() + " TL";
            }
            else if (cikis >= 1000 && cikis < 10000)
            {
                kasaCikis_lbl.Text = cikis.ToString()[0] + "." + cikis.ToString().Substring(1) + " TL";
            }
            else if (cikis >= 10000 && cikis < 100000 )
            {
                kasaCikis_lbl.Text = cikis.ToString().Substring(0, 2) + "." + cikis.ToString().Substring(2) + " TL";
            }
            else if (cikis >= 100000 && cikis < 1000000)
            {
                kasaCikis_lbl.Text = cikis.ToString().Substring(0, 3) + "." + cikis.ToString().Substring(3) + " TL";
            }
            else if (cikis >= 1000000 && cikis < 10000000)
            {
                kasaCikis_lbl.Text = cikis.ToString()[0] + "." + cikis.ToString().Substring(1, 3) + "." + cikis.ToString().Substring(4, 3) + " TL";
            }
            else
            {
                kasaCikis_lbl.Text = cikis.ToString() + " TL";
            }

            if (cmdgiristoplam.ExecuteScalar() != DBNull.Value)
            {
                kasa += Convert.ToInt32(cmdgiristoplam.ExecuteScalar());
            }
            if (cmdcikistoplam.ExecuteScalar() != DBNull.Value)
            {
                kasa -= Convert.ToInt32(cmdcikistoplam.ExecuteScalar());
            }

            //kasanın noktalanması
            if (kasa >= 0 && kasa < 1000)
            {
                kasaTutar_lbl.Text = kasa.ToString() + " TL";
            }
            else if (kasa >= 1000 && kasa < 10000)
            {
                kasaTutar_lbl.Text = kasa.ToString()[0] + "." + kasa.ToString().Substring(1) + " TL";
            }
            else if (kasa >= 10000 && kasa < 100000)
            {
                kasaTutar_lbl.Text = kasa.ToString().Substring(0, 2) + "." + kasa.ToString().Substring(2) + " TL";
            }
            else if (kasa >= 100000 && kasa < 1000000)
            {
                kasaTutar_lbl.Text = kasa.ToString().Substring(0, 3) + "." + kasa.ToString().Substring(3) + " TL";
            }
            else if (kasa >= 1000000 && kasa < 10000000)
            {
                kasaTutar_lbl.Text = kasa.ToString()[0] + "." + kasa.ToString().Substring(1, 3) + "." + kasa.ToString().Substring(4, 3) + " TL";
            }
            else if(kasa < 0 && kasa > -1000)
            {
                kasaTutar_lbl.Text = kasa.ToString() + " TL";
            }
            else if (kasa <= -1000 && kasa > -10000)
            {
                kasaTutar_lbl.Text = kasa.ToString()[0] + kasa.ToString().Substring(1, 1) +  "." + kasa.ToString().Substring(2) + " TL";
            }
            else if (kasa <= -10000 && kasa > -100000)
            {
                kasaTutar_lbl.Text = kasa.ToString()[0] + kasa.ToString().Substring(1, 2) + "." + kasa.ToString().Substring(3) + " TL";
            }
            else if (kasa <= -100000 && kasa > -1000000)
            {
                kasaTutar_lbl.Text = kasa.ToString()[0] + kasa.ToString().Substring(1, 3) + "." + kasa.ToString().Substring(4) + " TL";
            }
            else if (kasa <= -1000000 && kasa > -10000000)
            {
                kasaTutar_lbl.Text = kasa.ToString()[0] + kasa.ToString()[1] + "." + kasa.ToString().Substring(2, 3) + "." + kasa.ToString().Substring(5, 3) + " TL";
            }
            else
            {
                kasaTutar_lbl.Text = kasa.ToString() + " TL";
            }
            con.Close();
            return kasa;
            
        }
     
        private void HataKontrolGiris()
        {
            if (string.IsNullOrEmpty(girisAd_txt.Text) == false && string.IsNullOrEmpty(girisMiktar_txt.Text) == false)
            {
                if (int.TryParse(girisMiktar_txt.Text, out int result))
                {
                    VeriEkleGiris();
                    MessageBox.Show("Giriş Eklendi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Miktar'ı Sayı Olarak Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ad veya Miktar Boş Bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void HataKontrolCikis()
        {
            if (string.IsNullOrEmpty(cikisAd_txt.Text) == false && string.IsNullOrEmpty(cikisMiktar_txt.Text) == false)
            {
                if (int.TryParse(cikisMiktar_txt.Text, out int result))
                {
                    VeriEkleCikis();
                    MessageBox.Show("Çıkış Eklendi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Miktar'ı Sayı Olarak Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ad veya Miktar Boş Bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void HataKontrolAraGiris()
        {
            if (int.TryParse(girisMiktar_txt.Text, out int result))
            {
                VeriEkleCikis();
                MessageBox.Show("Çıkış Eklendi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Miktar'ı Sayı Olarak Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Temizle()
        {
            girisAd_txt.Clear();
            girisMiktar_txt.Clear();
            girisAciklama_txt.Clear();
            cikisAd_txt.Clear();
            cikisMiktar_txt.Clear();
            cikisAciklama_txt.Clear();
        }

        private void VeriEkleGiris()
        {
            con.Open();
            string insertQuery = "INSERT INTO GirisTable (ad, miktar, aciklama, tarih) VALUES (@value1, @value2, @value3, @value4)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@value1", girisAd_txt.Text);
            cmd.Parameters.AddWithValue("@value2", girisMiktar_txt.Text);
            cmd.Parameters.AddWithValue("@value3", girisAciklama_txt.Text);
            cmd.Parameters.AddWithValue("@value4", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
        }
        private void VeriEkleCikis()
        {
            con.Open();
            string insertQuery = "INSERT INTO CikisTable (ad, miktar, aciklama, tarih) VALUES (@value1, @value2, @value3, @value4)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@value1", cikisAd_txt.Text);
            cmd.Parameters.AddWithValue("@value2", cikisMiktar_txt.Text);
            cmd.Parameters.AddWithValue("@value3", cikisAciklama_txt.Text);
            cmd.Parameters.AddWithValue("@value4", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
        }

        private void DataDesign()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 42, 64);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 42, 64);
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        private void girisButton_Click(object sender, EventArgs e)
        {
            HataKontrolGiris();
            VerileriGoster();
            KasaHesapla();
            Temizle();
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            HataKontrolCikis();
            VerileriGoster();
            KasaHesapla();
            Temizle();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void araButton_Click_1(object sender, EventArgs e)
        {
            con.Open();
            if (string.IsNullOrEmpty(girisAd_txt.Text))
            {
                if (string.IsNullOrEmpty(girisMiktar_txt.Text))
                {
                    MessageBox.Show("Lütfen Ad veya Miktar bilgisi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (int.TryParse(girisMiktar_txt.Text, out int result))
                    {
                        SqlCommand cmd = new SqlCommand("Select * FROM GirisTable where miktar=@miktar", con);
                        cmd.Parameters.AddWithValue("miktar", girisMiktar_txt.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                            dataGridView1.Sort(dataGridView1.Columns["tarihDataGridViewTextBoxColumn"], ListSortDirection.Descending);

                        }
                        else
                        {
                            MessageBox.Show("Sonuç Bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Miktar'ı Sayı Olarak Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
            else
            {
                if (int.TryParse(girisMiktar_txt.Text, out int result))
                {
                    SqlCommand cmd = new SqlCommand("Select * FROM GirisTable where ad=@ad", con);
                    cmd.Parameters.AddWithValue("ad", girisAd_txt.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                        dataGridView1.Sort(dataGridView1.Columns["tarihDataGridViewTextBoxColumn"], ListSortDirection.Descending);

                    }
                    else
                    {
                        MessageBox.Show("Sonuç Bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Miktar'ı Sayı Olarak Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            con.Close();
            Temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
            VerileriGoster();
        }

        private void araCikisButton_Click(object sender, EventArgs e)
        {
            con.Open();
            if (string.IsNullOrEmpty(cikisAd_txt.Text))
            {
                if (string.IsNullOrEmpty(cikisMiktar_txt.Text))
                {
                    MessageBox.Show("Lütfen Ad veya Miktar bilgisi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (int.TryParse(girisMiktar_txt.Text, out int result))
                    {
                        SqlCommand cmd = new SqlCommand("Select * FROM CikisTable where miktar=@miktar", con);
                        cmd.Parameters.AddWithValue("miktar", cikisMiktar_txt.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView2.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Miktar'ı Sayı Olarak Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            else
            {
                if (int.TryParse(girisMiktar_txt.Text, out int result))
                {
                    SqlCommand cmd = new SqlCommand("Select * FROM CikisTable where ad=@ad", con);
                    cmd.Parameters.AddWithValue("ad", cikisAd_txt.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGridView2.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Miktar'ı Sayı Olarak Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            con.Close();
            Temizle();
        }

        private void girisSilButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedAd = dataGridView1.SelectedRows[0].Cells["adDataGridViewTextBoxColumn"].Value.ToString();

                // DataGridView'den satırı kaldır
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

                // Veritabanından satırı ad bilgisine göre sil
                con.Open();
                string insertQuery = "DELETE FROM GirisTable WHERE ad = @ad";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@ad", selectedAd);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Veri başarıyla silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silinecek veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Satır Seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            VerileriGoster();
            Temizle();
            KasaHesapla();
        }

        private void cikisSilButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string selectedAd = dataGridView2.SelectedRows[0].Cells["adDataGridViewTextBoxColumn1"].Value.ToString();

                // DataGridView'den satırı kaldır
                dataGridView2.Rows.Remove(dataGridView2.SelectedRows[0]);

                // Veritabanından satırı ad bilgisine göre sil
                con.Open();
                string insertQuery = "DELETE FROM CikisTable WHERE ad = @ad";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@ad", selectedAd);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Veri başarıyla silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silinecek veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Satır Seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            VerileriGoster();
            Temizle();
            KasaHesapla();
        }
    }
}
