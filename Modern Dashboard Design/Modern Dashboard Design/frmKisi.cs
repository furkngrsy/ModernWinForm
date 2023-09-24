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
    public partial class frmKisi : Form
    {
        SqlConnection con = new SqlConnection("Data Source=FURKAN\\SQLEXPRESS;Initial Catalog = Kasa; Integrated Security = True");

        public frmKisi()
        {
            InitializeComponent();
            VerileriGoster();
            DataDesign();
        }

        private void frmKisi_Load(object sender, EventArgs e)
        {

        }

        private void VerileriGoster()
        {
            tc_txt.MaxLength = 11; // TextBox'a en fazla 11 karakter girilebilir
            con.Open();
            string sqlQueryGiris = "SELECT * FROM KisiTable WHERE CAST (tarih AS DATE) = CAST (GETDATE() AS DATE)";
            SqlDataAdapter adapterGiris = new SqlDataAdapter(sqlQueryGiris, con);
            DataTable dataTableGiris = new DataTable();
            adapterGiris.Fill(dataTableGiris);
            dataGridView1.DataSource = dataTableGiris;
            dataGridView1.Sort(dataGridView1.Columns["TARİH"], ListSortDirection.Descending);
            con.Close();
        }
        private void VeriEkle()
        {
            con.Open();
            string insertQuery = "INSERT INTO KisiTable (ad, tc, defterno, ıban, telno, tarih) VALUES (@value1, @value2, @value3, @value4, @value5, @value6)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@value1", ad_txt.Text);
            cmd.Parameters.AddWithValue("@value2", tc_txt.Text);
            cmd.Parameters.AddWithValue("@value3", defterNo_txt.Text);
            cmd.Parameters.AddWithValue("@value4", IBAN_txt.Text);
            cmd.Parameters.AddWithValue("@value5", telNo_txt.Text);
            cmd.Parameters.AddWithValue("@value6", DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
        }
        private void HataKontrol()
        {
            if (string.IsNullOrEmpty(ad_txt.Text) == false && string.IsNullOrEmpty(telNo_txt.Text) == false && string.IsNullOrEmpty(tc_txt.Text) == false)
            {
                VeriEkle();
                MessageBox.Show("Kişi Eklendi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ad, TC veya Telefon Numarası Boş Bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void VeriSil()
        {
            con.Open();
            string insertQuery = "DELETE FROM KisiTable WHERE ad = @ad";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@ad", ad_txt.Text);
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
        }
        private void Temizle()
        {
            telNo_txt.Clear();
            ad_txt.Clear();
            tc_txt.Clear();
            defterNo_txt.Clear();
            IBAN_txt.Clear();
        }
        private void araButton_Click(object sender, EventArgs e)
        {
            con.Open();
            if (string.IsNullOrEmpty(ad_txt.Text))
            {
                if (string.IsNullOrEmpty(tc_txt.Text))
                {
                    if (string.IsNullOrEmpty(telNo_txt.Text))
                    {
                        MessageBox.Show("Lütfen Ad, TC veya Telefon Numarası Bilgisi Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("Select * FROM KisiTable where telno=@telno", con);
                        cmd.Parameters.AddWithValue("telno", telNo_txt.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                            dataGridView1.Sort(dataGridView1.Columns["TARİH"], ListSortDirection.Descending);

                        }
                        else
                        {
                            MessageBox.Show("Sonuç Bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select * FROM KisiTable where tc=@tc", con);
                    cmd.Parameters.AddWithValue("tc", tc_txt.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                        dataGridView1.Sort(dataGridView1.Columns["TARİH"], ListSortDirection.Descending);

                    }
                    else
                    {
                        MessageBox.Show("Sonuç Bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * FROM KisiTable where ad=@ad", con);
                cmd.Parameters.AddWithValue("ad", ad_txt.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Sort(dataGridView1.Columns["TARİH"], ListSortDirection.Descending);

                }
                else
                {
                    MessageBox.Show("Sonuç Bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            con.Close();
            Temizle();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            HataKontrol();
            VerileriGoster();
            Temizle();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedAd = dataGridView1.SelectedRows[0].Cells["adDataGridViewTextBoxColumn"].Value.ToString();

                // DataGridView'den satırı kaldır
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

                // Veritabanından satırı ad bilgisine göre sil
                con.Open();
                string insertQuery = "DELETE FROM KisiTable WHERE ad = @ad";
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
                MessageBox.Show("Lütfen bir satır seçin.");
            }
            VerileriGoster();
            Temizle();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }

        private void yenile_Button_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }
    }
}
