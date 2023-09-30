using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Dashboard_Design
{
    public partial class frmCalander : Form
    {
        SqlConnection con = new SqlConnection("Data Source=FURKAN\\SQLEXPRESS;Initial Catalog = Kasa; Integrated Security = True");
        public frmCalander()
        {
            InitializeComponent();
            VerileriGoster();
            DataDesign();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmCalander_Load(object sender, EventArgs e)
        {

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

            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 42, 64);
            dataGridView3.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void VerileriGoster()
        {
            string sqlQueryFis = "SELECT * FROM FisTable";
            SqlDataAdapter adapterFis = new SqlDataAdapter(sqlQueryFis, con);
            DataTable dataTableFis = new DataTable();
            adapterFis.Fill(dataTableFis);
            dataGridView1.DataSource = dataTableFis;
            dataGridView1.Sort(dataGridView1.Columns["tarihDataGridViewTextBoxColumn"], ListSortDirection.Descending);

            string sqlQueryGiris = "SELECT * FROM GirisTable";
            SqlDataAdapter adapterGiris = new SqlDataAdapter(sqlQueryGiris, con);
            DataTable dataTableGiris = new DataTable();
            adapterGiris.Fill(dataTableGiris);
            dataGridView2.DataSource = dataTableGiris;
            dataGridView2.Sort(dataGridView2.Columns["dataGridViewTextBoxColumn7"], ListSortDirection.Descending);

            string sqlQueryCikis = "SELECT * FROM CikisTable";
            SqlDataAdapter adapterCikis = new SqlDataAdapter(sqlQueryCikis, con);
            DataTable dataTableCikis = new DataTable();
            adapterCikis.Fill(dataTableCikis);
            dataGridView3.DataSource = dataTableCikis;
            dataGridView3.Sort(dataGridView3.Columns["dataGridViewTextBoxColumn14"], ListSortDirection.Descending);
            con.Close();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            con.Open();
            DateTime selectedDate = dateTimePicker1.Value;

            string sqlQueryFis = "SELECT * FROM FisTable WHERE CONVERT(date, tarih) = @SelectedDate";
            SqlCommand command = new SqlCommand(sqlQueryFis, con);
            command.Parameters.AddWithValue("@SelectedDate", selectedDate.Date);
            SqlDataAdapter adapterFis = new SqlDataAdapter(command);
            DataTable dataTableFis = new DataTable();
            adapterFis.Fill(dataTableFis);
            

            string sqlQueryGiris = "SELECT * FROM GirisTable WHERE CONVERT(date, tarih) = @SelectedDate";
            SqlCommand commandGiris = new SqlCommand(sqlQueryGiris, con);
            commandGiris.Parameters.AddWithValue("@SelectedDate", selectedDate.Date);
            SqlDataAdapter adapterGiris = new SqlDataAdapter(commandGiris);
            DataTable dataTableGiris = new DataTable();
            adapterGiris.Fill(dataTableGiris);


            string sqlQueryCikis = "SELECT * FROM CikisTable WHERE CONVERT(date, tarih) = @SelectedDate";
            SqlCommand commandCikis = new SqlCommand(sqlQueryCikis, con);
            commandCikis.Parameters.AddWithValue("@SelectedDate", selectedDate.Date);
            SqlDataAdapter adapterCikis = new SqlDataAdapter(commandCikis);
            DataTable dataTableCikis = new DataTable();
            adapterCikis.Fill(dataTableCikis);

            int sayac = 0;
            if(dataTableFis.Rows.Count > 0)
            {
                dataGridView1.DataSource = dataTableFis;
                dataGridView1.Sort(dataGridView1.Columns["tarihDataGridViewTextBoxColumn"], ListSortDirection.Descending);
            }
            else
            {
                sayac += 1;
            }
            if (dataTableGiris.Rows.Count > 0)
            {
                dataGridView2.DataSource = dataTableGiris;
                dataGridView2.Sort(dataGridView2.Columns["dataGridViewTextBoxColumn7"], ListSortDirection.Descending);
            }
            else
            {
                sayac += 5;
            }
            if (dataTableCikis.Rows.Count > 0)
            {
                dataGridView3.DataSource = dataTableCikis;
                dataGridView3.Sort(dataGridView3.Columns["dataGridViewTextBoxColumn14"], ListSortDirection.Descending);
            }
            else
            {
                sayac += 10;
            }

            if (sayac == 1)
            {
                MessageBox.Show("Seçilen tarihte fiş bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (sayac == 5)
            {
                MessageBox.Show("Seçilen tarihte kasa girişi bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(sayac == 10)
            {
                MessageBox.Show("Seçilen tarihte kasa çıkışı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (sayac == 6)
            {
                MessageBox.Show("Seçilen tarihte  fiş ve kasa çıkışı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (sayac == 11)
            {
                MessageBox.Show("Seçilen tarihte fiş ve kasa çıkışı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (sayac == 15)
            {
                MessageBox.Show("Seçilen tarihte kasa girişi ve çıkışı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(sayac == 16)
            {
                MessageBox.Show("Seçilen tarihte fiş, kasa girişi ve kasa çıkışı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void girisSilButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedfis = dataGridView1.SelectedRows[0].Cells["fisNoDataGridViewTextBoxColumn"].Value.ToString();

                // DataGridView'den satırı kaldır
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

                // Veritabanından satırı ad bilgisine göre sil
                con.Open();
                string insertQuery = "DELETE FROM FisTable WHERE fisNo = @fisNo";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@fisNo", selectedfis);
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

            else if (dataGridView2.SelectedRows.Count > 0)
            {
                 string selectedad = dataGridView2.SelectedRows[0].Cells["dataGridViewTextBoxColumn2"].Value.ToString();

                 // DataGridView'den satırı kaldır
                 dataGridView2.Rows.Remove(dataGridView2.SelectedRows[0]);
                 
                 // Veritabanından satırı ad bilgisine göre sil
                 con.Open();
                 string insertQuery = "DELETE FROM GirisTable WHERE ad = @ad";
                 SqlCommand cmd = new SqlCommand(insertQuery, con);
                 cmd.Parameters.AddWithValue("@ad", selectedad);
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
            else if (dataGridView3.SelectedRows.Count > 0)
            {
                string selectedad = dataGridView3.SelectedRows[0].Cells["dataGridViewTextBoxColumn9"].Value.ToString();

                // DataGridView'den satırı kaldır
                dataGridView3.Rows.Remove(dataGridView3.SelectedRows[0]);

                // Veritabanından satırı ad bilgisine göre sil
                con.Open();
                string insertQuery = "DELETE FROM CikisTable WHERE ad = @ad";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@ad", selectedad);
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
        }

        private void PrintGiris()
        {
            // Veritabanı bağlantı dizesini ayarlayın
            string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog = Kasa; Integrated Security = True";

            // Yazdırma işlemi için gerekli nesneleri oluşturun
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler((sender, e) => PrintPage(sender, e, connectionString, "GirisTable")); // Tablo adını belirtin

            // Yazdırma işlemini başlatın
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintCikis()
        {
            // Veritabanı bağlantı dizesini ayarlayın
            string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog = Kasa; Integrated Security = True";

            // Yazdırma işlemi için gerekli nesneleri oluşturun
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler((sender, e) => PrintPage(sender, e, connectionString, "CikisTable")); // Tablo adını belirtin

            // Yazdırma işlemini başlatın
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintFis()
        {
            // Veritabanı bağlantı dizesini ayarlayın
            string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog = Kasa; Integrated Security = True";

            // Yazdırma işlemi için gerekli nesneleri oluşturun
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler((sender, e) => PrintPage(sender, e, connectionString, "FisTable")); // Tablo adını belirtin

            // Yazdırma işlemini başlatın
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintKisi()
        {
            // Veritabanı bağlantı dizesini ayarlayın
            string connectionString = "Data Source=FURKAN\\SQLEXPRESS;Initial Catalog = Kasa; Integrated Security = True";

            // Yazdırma işlemi için gerekli nesneleri oluşturun
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler((sender, e) => PrintPage(sender, e, connectionString, "KisiTable")); // Tablo adını belirtin

            // Yazdırma işlemini başlatın
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e, string connectionString, string tableName)
        {
            // Yazdırma işlemi için kullanılacak grafik nesnesini alın.
            Graphics graphics = e.Graphics;

            // Yazdırma işlemi sırasında kullanılacak yazı fontunu belirleyin.
            Font font = new Font("Bahnscrift", 12);

            // Yazdırma işlemi sırasında kullanılacak metin rengini belirleyin.
            SolidBrush brush = new SolidBrush(Color.Black);

            // Yazdırma işlemi sırasında kullanılacak metin başlangıç noktasını belirleyin.
            float startX = 10;
            float startY = 10;

            // Veritabanından sütun başlıklarını okuyarak yazdırın.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DateTime selectedDate = dateTimePicker1.Value;
                string query = $"SELECT * FROM {tableName} WHERE CONVERT(date, tarih) = @SelectedDate";
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SelectedDate", selectedDate.Date);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Sütun başlıklarını yazdırın
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string headerToPrint = reader.GetName(i); // Sütun adını alın

                            graphics.DrawString(headerToPrint.ToUpper(), font, brush, startX, startY);
                            startX += 115; // Sütunları ayırmak için 150 birim ilerleyin.
                        }

                        startY += 20; // Başlık satırını yazdırdıktan sonra alt satıra geçin
                        startX = 10; // Sütun başına geri dönün.

                        // Verileri yazdırmadan önce bir satır boşluk bırakın
                        startY += 20;

                        // Verileri okuyarak yazdırın
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string dataToPrint = reader[i].ToString();
                                graphics.DrawString(dataToPrint, font, brush, startX, startY);
                                startX += 115; // Sütunları ayırmak için 150 birim ilerleyin.
                            }
                            startY += 20; // Alt satıra geçmek için 20 birim ilerleyin.
                            startX = 10; // Sütun başına geri dönün.

                        }
                    }
                }
            }

            // Herhangi bir sayfa daha kalmadığını belirtin.
            e.HasMorePages = false;

            // Kullanılan nesneleri temizleyin.
            font.Dispose();
            brush.Dispose();
        }
        private void yazdir_Button_Click(object sender, EventArgs e)
        {
            
            // Seçilen veritabanını alın
            if(database_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Seçeneklerden Birini Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string selectedDatabase = database_comboBox.SelectedItem.ToString(); // ComboBox kullanıyorsanız

                // Seçilen veritabanına göre yazdırma işlemini başlatın
                if (selectedDatabase == "Kasa Giriş")
                {
                    PrintGiris();
                }
                else if (selectedDatabase == "Kasa Çıkış")
                {
                    PrintCikis();
                }
                else if (selectedDatabase == "Fiş")
                {
                    PrintFis();
                }
                else if (selectedDatabase == "Kişi")
                {
                    PrintKisi();
                }
            }
            
        }
    }
}
