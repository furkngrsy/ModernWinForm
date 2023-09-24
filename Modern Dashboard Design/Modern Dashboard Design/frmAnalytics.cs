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

namespace Modern_Dashboard_Design
{
    public partial class frmAnalytics : Form
    {

        SqlConnection con = new SqlConnection("Data Source=FURKAN\\SQLEXPRESS;Initial Catalog = Kasa; Integrated Security = True");
        
        public frmAnalytics()
        {
            InitializeComponent();
            VerileriGoster();
            DataDesign();
        }
        private void frmAnalytics_Load(object sender, EventArgs e)
        {

        }
        private void VerileriGoster()
        {
            tc_txt.MaxLength = 11; // TextBox'a en fazla 50 karakter girilebilir
            con.Open();
            string sqlQueryGiris = "SELECT * FROM FisTable WHERE CAST (tarih AS DATE) = CAST (GETDATE() AS DATE)";
            SqlDataAdapter adapterGiris = new SqlDataAdapter(sqlQueryGiris, con);
            DataTable dataTableGiris = new DataTable();
            adapterGiris.Fill(dataTableGiris);
            dataGridView1.DataSource = dataTableGiris;
            dataGridView1.Sort(dataGridView1.Columns["tarihDataGridViewTextBoxColumn"], ListSortDirection.Descending);
            con.Close();
        }
        private void Temizle()
        {
            fisNo_txt.Clear();
            textBox1.Clear();
            tc_txt.Clear();
            miktar_txt.Clear();
            rnd_txt.Clear();
            cuvalS_txt.Clear();
        }
        private void HataKontrol()
        {
            if (string.IsNullOrEmpty(fisNo_txt.Text) == false && string.IsNullOrEmpty(textBox1.Text) == false && string.IsNullOrEmpty(miktar_txt.Text) == false)
            {
                if (int.TryParse(miktar_txt.Text, out int result))
                {
                    VeriEkle();
                    MessageBox.Show("Fiş Eklendi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Miktar'ı Sayı Olarak Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Fiş Numarası, Ad ve Miktar Boş Bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void VeriEkle()
        {
            con.Open();
            string insertQuery = "INSERT INTO FisTable (fisNo, ad, tc, miktar, randuman, cuvalSayisi, tarih) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@value1", fisNo_txt.Text);
            cmd.Parameters.AddWithValue("@value2", textBox1.Text);
            cmd.Parameters.AddWithValue("@value3", tc_txt.Text);
            cmd.Parameters.AddWithValue("@value4", miktar_txt.Text);
            cmd.Parameters.AddWithValue("@value5", rnd_txt.Text);
            cmd.Parameters.AddWithValue("@value6", cuvalS_txt.Text);
            cmd.Parameters.AddWithValue("@value7", DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
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
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            HataKontrol();
            VerileriGoster();
            Temizle();
        }

        private void ara_Button_Click(object sender, EventArgs e)
        {
            con.Open();
            if (string.IsNullOrEmpty(fisNo_txt.Text))
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    if (string.IsNullOrEmpty(tc_txt.Text))
                    {
                        MessageBox.Show("Lütfen Fiş Numarası, Ad veya TC bilgisi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("Select * FROM FisTable where tc=@tc", con);
                        cmd.Parameters.AddWithValue("tc", tc_txt.Text);
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
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select * FROM FisTable where ad=@ad", con);
                    cmd.Parameters.AddWithValue("ad", textBox1.Text);
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
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * FROM FisTable where fisNo=@fisNo", con);
                cmd.Parameters.AddWithValue("fisNo", fisNo_txt.Text);
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
            con.Close();
            Temizle();
        }

        private void yenile_Button_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void button1_Click(object sender, EventArgs e)//Veri silme
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedfis = dataGridView1.SelectedRows[0].Cells["fisNoDataGridViewTextBoxColumn"].Value.ToString();

                // DataGridView'den satırı kaldır
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

                // Veritabanından satırı ad bilgisine göre sil
                con.Open();
                string insertQuery = "DELETE FROM FisTable WHERE fis = @fis";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@fis", selectedfis);
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
