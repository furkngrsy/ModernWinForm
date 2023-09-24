namespace Modern_Dashboard_Design
{
    partial class frmAnalytics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fisNo_txt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tc_txt = new System.Windows.Forms.TextBox();
            this.miktar_txt = new System.Windows.Forms.TextBox();
            this.rnd_txt = new System.Windows.Forms.TextBox();
            this.cuvalS_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ad_txt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.girisButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fisNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randumanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuvalSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kasaDataSet2 = new Modern_Dashboard_Design.KasaDataSet2();
            this.ara_Button = new System.Windows.Forms.Button();
            this.fisTableTableAdapter = new Modern_Dashboard_Design.KasaDataSet2TableAdapters.FisTableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.yenile_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // fisNo_txt
            // 
            this.fisNo_txt.Location = new System.Drawing.Point(270, 102);
            this.fisNo_txt.Name = "fisNo_txt";
            this.fisNo_txt.Size = new System.Drawing.Size(100, 20);
            this.fisNo_txt.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // tc_txt
            // 
            this.tc_txt.Location = new System.Drawing.Point(540, 102);
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(100, 20);
            this.tc_txt.TabIndex = 7;
            // 
            // miktar_txt
            // 
            this.miktar_txt.Location = new System.Drawing.Point(673, 102);
            this.miktar_txt.Name = "miktar_txt";
            this.miktar_txt.Size = new System.Drawing.Size(100, 20);
            this.miktar_txt.TabIndex = 8;
            // 
            // rnd_txt
            // 
            this.rnd_txt.Location = new System.Drawing.Point(803, 102);
            this.rnd_txt.Name = "rnd_txt";
            this.rnd_txt.Size = new System.Drawing.Size(100, 20);
            this.rnd_txt.TabIndex = 9;
            // 
            // cuvalS_txt
            // 
            this.cuvalS_txt.Location = new System.Drawing.Point(929, 102);
            this.cuvalS_txt.Name = "cuvalS_txt";
            this.cuvalS_txt.Size = new System.Drawing.Size(100, 20);
            this.cuvalS_txt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(272, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fiş Numarası";
            // 
            // ad_txt
            // 
            this.ad_txt.AutoSize = true;
            this.ad_txt.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad_txt.ForeColor = System.Drawing.SystemColors.Control;
            this.ad_txt.Location = new System.Drawing.Point(442, 81);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(26, 18);
            this.ad_txt.TabIndex = 13;
            this.ad_txt.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(577, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "TC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(697, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Miktar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(815, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Randıman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(940, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Çuval Sayısı";
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.girisButton.FlatAppearance.BorderSize = 0;
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.girisButton.Location = new System.Drawing.Point(606, 145);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(115, 42);
            this.girisButton.TabIndex = 18;
            this.girisButton.Text = "Fiş Ekle";
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fisNoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.tcDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.randumanDataGridViewTextBoxColumn,
            this.cuvalSayisiDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fisTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(217, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(883, 439);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fisNoDataGridViewTextBoxColumn
            // 
            this.fisNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fisNoDataGridViewTextBoxColumn.DataPropertyName = "fisNo";
            this.fisNoDataGridViewTextBoxColumn.HeaderText = "Fiş Numarası";
            this.fisNoDataGridViewTextBoxColumn.Name = "fisNoDataGridViewTextBoxColumn";
            this.fisNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Miktar";
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            this.miktarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // randumanDataGridViewTextBoxColumn
            // 
            this.randumanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.randumanDataGridViewTextBoxColumn.DataPropertyName = "randuman";
            this.randumanDataGridViewTextBoxColumn.HeaderText = "Randıman";
            this.randumanDataGridViewTextBoxColumn.Name = "randumanDataGridViewTextBoxColumn";
            this.randumanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuvalSayisiDataGridViewTextBoxColumn
            // 
            this.cuvalSayisiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cuvalSayisiDataGridViewTextBoxColumn.DataPropertyName = "cuvalSayisi";
            this.cuvalSayisiDataGridViewTextBoxColumn.HeaderText = "Çuval Sayısı";
            this.cuvalSayisiDataGridViewTextBoxColumn.Name = "cuvalSayisiDataGridViewTextBoxColumn";
            this.cuvalSayisiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fisTableBindingSource
            // 
            this.fisTableBindingSource.DataMember = "FisTable";
            this.fisTableBindingSource.DataSource = this.kasaDataSet2;
            // 
            // kasaDataSet2
            // 
            this.kasaDataSet2.DataSetName = "KasaDataSet2";
            this.kasaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ara_Button
            // 
            this.ara_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ara_Button.FlatAppearance.BorderSize = 0;
            this.ara_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ara_Button.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ara_Button.Location = new System.Drawing.Point(457, 145);
            this.ara_Button.Name = "ara_Button";
            this.ara_Button.Size = new System.Drawing.Size(115, 42);
            this.ara_Button.TabIndex = 20;
            this.ara_Button.Text = "Ara";
            this.ara_Button.UseVisualStyleBackColor = false;
            this.ara_Button.Click += new System.EventHandler(this.ara_Button_Click);
            // 
            // fisTableTableAdapter
            // 
            this.fisTableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(753, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yenile_Button
            // 
            this.yenile_Button.FlatAppearance.BorderSize = 0;
            this.yenile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yenile_Button.ForeColor = System.Drawing.Color.White;
            this.yenile_Button.Image = global::Modern_Dashboard_Design.Properties.Resources.Refresh_PNG_Picture1;
            this.yenile_Button.Location = new System.Drawing.Point(1263, 12);
            this.yenile_Button.Name = "yenile_Button";
            this.yenile_Button.Size = new System.Drawing.Size(48, 41);
            this.yenile_Button.TabIndex = 21;
            this.yenile_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.yenile_Button.UseVisualStyleBackColor = true;
            this.yenile_Button.Click += new System.EventHandler(this.yenile_Button_Click);
            // 
            // frmAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1323, 671);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yenile_Button);
            this.Controls.Add(this.ara_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ad_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cuvalS_txt);
            this.Controls.Add(this.rnd_txt);
            this.Controls.Add(this.miktar_txt);
            this.Controls.Add(this.tc_txt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fisNo_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnalytics";
            this.Text = "frmAnalytics";
            this.Load += new System.EventHandler(this.frmAnalytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fisNo_txt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tc_txt;
        private System.Windows.Forms.TextBox miktar_txt;
        private System.Windows.Forms.TextBox rnd_txt;
        private System.Windows.Forms.TextBox cuvalS_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ad_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ara_Button;
        private System.Windows.Forms.Button yenile_Button;
        private KasaDataSet2 kasaDataSet2;
        private System.Windows.Forms.BindingSource fisTableBindingSource;
        private KasaDataSet2TableAdapters.FisTableTableAdapter fisTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randumanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuvalSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}