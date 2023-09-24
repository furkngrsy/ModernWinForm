namespace Modern_Dashboard_Design
{
    partial class frmKisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ad_txt = new System.Windows.Forms.TextBox();
            this.telNo_txt = new System.Windows.Forms.TextBox();
            this.IBAN_txt = new System.Windows.Forms.TextBox();
            this.defterNo_txt = new System.Windows.Forms.TextBox();
            this.tc_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıbanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARİH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kasaDataSet8 = new Modern_Dashboard_Design.KasaDataSet8();
            this.kasaDataSet7 = new Modern_Dashboard_Design.KasaDataSet7();
            this.kisiTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kisiTableTableAdapter = new Modern_Dashboard_Design.KasaDataSet7TableAdapters.KisiTableTableAdapter();
            this.araButton = new System.Windows.Forms.Button();
            this.ekleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.kisiTableTableAdapter1 = new Modern_Dashboard_Design.KasaDataSet8TableAdapters.KisiTableTableAdapter();
            this.yenile_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(287, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(452, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "TC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(568, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Defter Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(783, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "IBAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(920, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Telefon Numarası";
            // 
            // ad_txt
            // 
            this.ad_txt.Location = new System.Drawing.Point(252, 106);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(100, 20);
            this.ad_txt.TabIndex = 19;
            // 
            // telNo_txt
            // 
            this.telNo_txt.Location = new System.Drawing.Point(918, 106);
            this.telNo_txt.Name = "telNo_txt";
            this.telNo_txt.Size = new System.Drawing.Size(127, 20);
            this.telNo_txt.TabIndex = 20;
            // 
            // IBAN_txt
            // 
            this.IBAN_txt.Location = new System.Drawing.Point(754, 106);
            this.IBAN_txt.Name = "IBAN_txt";
            this.IBAN_txt.Size = new System.Drawing.Size(100, 20);
            this.IBAN_txt.TabIndex = 21;
            // 
            // defterNo_txt
            // 
            this.defterNo_txt.Location = new System.Drawing.Point(566, 106);
            this.defterNo_txt.Name = "defterNo_txt";
            this.defterNo_txt.Size = new System.Drawing.Size(122, 20);
            this.defterNo_txt.TabIndex = 22;
            // 
            // tc_txt
            // 
            this.tc_txt.Location = new System.Drawing.Point(413, 106);
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(100, 20);
            this.tc_txt.TabIndex = 23;
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
            this.adDataGridViewTextBoxColumn,
            this.tcDataGridViewTextBoxColumn,
            this.defternoDataGridViewTextBoxColumn,
            this.ıbanDataGridViewTextBoxColumn,
            this.telnoDataGridViewTextBoxColumn,
            this.TARİH});
            this.dataGridView1.DataSource = this.kisiTableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(194, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(883, 439);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
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
            // defternoDataGridViewTextBoxColumn
            // 
            this.defternoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.defternoDataGridViewTextBoxColumn.DataPropertyName = "defterno";
            this.defternoDataGridViewTextBoxColumn.HeaderText = "Defter Numarası";
            this.defternoDataGridViewTextBoxColumn.Name = "defternoDataGridViewTextBoxColumn";
            this.defternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıbanDataGridViewTextBoxColumn
            // 
            this.ıbanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ıbanDataGridViewTextBoxColumn.DataPropertyName = "ıban";
            this.ıbanDataGridViewTextBoxColumn.HeaderText = "IBAN";
            this.ıbanDataGridViewTextBoxColumn.Name = "ıbanDataGridViewTextBoxColumn";
            this.ıbanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telnoDataGridViewTextBoxColumn
            // 
            this.telnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telnoDataGridViewTextBoxColumn.DataPropertyName = "telno";
            this.telnoDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.telnoDataGridViewTextBoxColumn.Name = "telnoDataGridViewTextBoxColumn";
            this.telnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TARİH
            // 
            this.TARİH.DataPropertyName = "tarih";
            this.TARİH.HeaderText = "Tarih";
            this.TARİH.Name = "TARİH";
            this.TARİH.ReadOnly = true;
            // 
            // kisiTableBindingSource1
            // 
            this.kisiTableBindingSource1.DataMember = "KisiTable";
            this.kisiTableBindingSource1.DataSource = this.kasaDataSet8;
            // 
            // kasaDataSet8
            // 
            this.kasaDataSet8.DataSetName = "KasaDataSet8";
            this.kasaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasaDataSet7
            // 
            this.kasaDataSet7.DataSetName = "KasaDataSet7";
            this.kasaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kisiTableBindingSource
            // 
            this.kisiTableBindingSource.DataMember = "KisiTable";
            this.kisiTableBindingSource.DataSource = this.kasaDataSet7;
            // 
            // kisiTableTableAdapter
            // 
            this.kisiTableTableAdapter.ClearBeforeFill = true;
            // 
            // araButton
            // 
            this.araButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.araButton.FlatAppearance.BorderSize = 0;
            this.araButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.araButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.araButton.Location = new System.Drawing.Point(361, 143);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(115, 42);
            this.araButton.TabIndex = 26;
            this.araButton.Text = "Ara";
            this.araButton.UseVisualStyleBackColor = false;
            this.araButton.Click += new System.EventHandler(this.araButton_Click);
            // 
            // ekleButton
            // 
            this.ekleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ekleButton.FlatAppearance.BorderSize = 0;
            this.ekleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ekleButton.Location = new System.Drawing.Point(566, 143);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(115, 42);
            this.ekleButton.TabIndex = 27;
            this.ekleButton.Text = "Kişi Ekle";
            this.ekleButton.UseVisualStyleBackColor = false;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // silButton
            // 
            this.silButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.silButton.FlatAppearance.BorderSize = 0;
            this.silButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.ForeColor = System.Drawing.Color.Red;
            this.silButton.Location = new System.Drawing.Point(795, 143);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(115, 42);
            this.silButton.TabIndex = 28;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = false;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // kisiTableTableAdapter1
            // 
            this.kisiTableTableAdapter1.ClearBeforeFill = true;
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
            this.yenile_Button.TabIndex = 29;
            this.yenile_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.yenile_Button.UseVisualStyleBackColor = true;
            this.yenile_Button.Click += new System.EventHandler(this.yenile_Button_Click);
            // 
            // frmKisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1323, 671);
            this.Controls.Add(this.yenile_Button);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tc_txt);
            this.Controls.Add(this.defterNo_txt);
            this.Controls.Add(this.IBAN_txt);
            this.Controls.Add(this.telNo_txt);
            this.Controls.Add(this.ad_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKisi";
            this.Text = "frmGelecek";
            this.Load += new System.EventHandler(this.frmKisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kisiTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ad_txt;
        private System.Windows.Forms.TextBox telNo_txt;
        private System.Windows.Forms.TextBox IBAN_txt;
        private System.Windows.Forms.TextBox defterNo_txt;
        private System.Windows.Forms.TextBox tc_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KasaDataSet7 kasaDataSet7;
        private System.Windows.Forms.BindingSource kisiTableBindingSource;
        private KasaDataSet7TableAdapters.KisiTableTableAdapter kisiTableTableAdapter;
        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Button silButton;
        private KasaDataSet8 kasaDataSet8;
        private System.Windows.Forms.BindingSource kisiTableBindingSource1;
        private KasaDataSet8TableAdapters.KisiTableTableAdapter kisiTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıbanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARİH;
        private System.Windows.Forms.Button yenile_Button;
    }
}