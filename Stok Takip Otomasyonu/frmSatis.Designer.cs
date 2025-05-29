using System;

namespace Stok_Takip_Otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.müşteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_Takip1DataSet1 = new Stok_Takip_Otomasyonu.Stok_Takip1DataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplamFiyati = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtMitkari = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.müşteriTableAdapter = new Stok_Takip_Otomasyonu.Stok_Takip1DataSet1TableAdapters.müşteriTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tcDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sepetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_Takip1DataSet3 = new Stok_Takip_Otomasyonu.Stok_Takip1DataSet3();
            this.sepetTableAdapter = new Stok_Takip_Otomasyonu.Stok_Takip1DataSet3TableAdapters.sepetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.müşteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_Takip1DataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_Takip1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // müşteriBindingSource
            // 
            this.müşteriBindingSource.DataMember = "müşteri";
            this.müşteriBindingSource.DataSource = this.stok_Takip1DataSet1;
            // 
            // stok_Takip1DataSet1
            // 
            this.stok_Takip1DataSet1.DataSetName = "Stok_Takip1DataSet1";
            this.stok_Takip1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(40, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC :";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(104, 130);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 24);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(104, 76);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 24);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(104, 22);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 24);
            this.txtTc.TabIndex = 0;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtToplamFiyati);
            this.groupBox2.Controls.Add(this.txtSatisFiyati);
            this.groupBox2.Controls.Add(this.txtMitkari);
            this.groupBox2.Controls.Add(this.txtUrunAdi);
            this.groupBox2.Controls.Add(this.txtBarkodNo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(40, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 195);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-3, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Toplam Fiyatı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Satış Fiyatı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Miktarı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ürün Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Barkod No :";
            // 
            // txtToplamFiyati
            // 
            this.txtToplamFiyati.Location = new System.Drawing.Point(104, 143);
            this.txtToplamFiyati.Name = "txtToplamFiyati";
            this.txtToplamFiyati.Size = new System.Drawing.Size(100, 24);
            this.txtToplamFiyati.TabIndex = 5;
            this.txtToplamFiyati.Text = "00.00";
            this.txtToplamFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToplamFiyati.TextChanged += new System.EventHandler(this.txtToplamFiyati_TextChanged);
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(104, 115);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(100, 24);
            this.txtSatisFiyati.TabIndex = 4;
            this.txtSatisFiyati.Text = "00.00";
            this.txtSatisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMitkari
            // 
            this.txtMitkari.Location = new System.Drawing.Point(104, 87);
            this.txtMitkari.Name = "txtMitkari";
            this.txtMitkari.Size = new System.Drawing.Size(100, 24);
            this.txtMitkari.TabIndex = 3;
            this.txtMitkari.Text = "1";
            this.txtMitkari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMitkari.TextChanged += new System.EventHandler(this.txtMitkari_TextChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(104, 59);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 24);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(104, 31);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 24);
            this.txtBarkodNo.TabIndex = 1;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(378, 533);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 49);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(1131, 118);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 70);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil ";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisIptal.Location = new System.Drawing.Point(1131, 209);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(75, 68);
            this.btnSatisIptal.TabIndex = 5;
            this.btnSatisIptal.Text = "Satış İptal ";
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            this.btnSatisIptal.Click += new System.EventHandler(this.btnSatisIptal_Click);
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisYap.Location = new System.Drawing.Point(921, 533);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(127, 49);
            this.btnSatisYap.TabIndex = 6;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(618, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Genel Toplam :";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenelToplam.Location = new System.Drawing.Point(747, 550);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(52, 20);
            this.lblGenelToplam.TabIndex = 8;
            this.lblGenelToplam.Text = "00 TL";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 100);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(608, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 62);
            this.button3.TabIndex = 7;
            this.button3.Text = "Ürün Listele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1062, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Marka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(953, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 62);
            this.button2.TabIndex = 5;
            this.button2.Text = "Kategori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(785, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 62);
            this.button9.TabIndex = 4;
            this.button9.Text = "Satış Listeleme";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(483, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 62);
            this.button7.TabIndex = 2;
            this.button7.Text = "Ürün Ekleme ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(250, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 62);
            this.button6.TabIndex = 1;
            this.button6.Text = "Müşteri Listeleme";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(120, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 62);
            this.button5.TabIndex = 0;
            this.button5.Text = "Müşteri Ekleme ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // müşteriTableAdapter
            // 
            this.müşteriTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcDataGridViewTextBoxColumn1,
            this.adsoyadDataGridViewTextBoxColumn1,
            this.telefonDataGridViewTextBoxColumn1,
            this.barkodnoDataGridViewTextBoxColumn,
            this.urunadiDataGridViewTextBoxColumn,
            this.miktariDataGridViewTextBoxColumn,
            this.satisfiyatiDataGridViewTextBoxColumn,
            this.toplamfiyatDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sepetBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(274, 118);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(836, 400);
            this.dataGridView2.TabIndex = 10;
            // 
            // tcDataGridViewTextBoxColumn1
            // 
            this.tcDataGridViewTextBoxColumn1.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn1.HeaderText = "tc";
            this.tcDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tcDataGridViewTextBoxColumn1.Name = "tcDataGridViewTextBoxColumn1";
            this.tcDataGridViewTextBoxColumn1.Width = 125;
            // 
            // adsoyadDataGridViewTextBoxColumn1
            // 
            this.adsoyadDataGridViewTextBoxColumn1.DataPropertyName = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn1.HeaderText = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.adsoyadDataGridViewTextBoxColumn1.Name = "adsoyadDataGridViewTextBoxColumn1";
            this.adsoyadDataGridViewTextBoxColumn1.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn1
            // 
            this.telefonDataGridViewTextBoxColumn1.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn1.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn1.Name = "telefonDataGridViewTextBoxColumn1";
            this.telefonDataGridViewTextBoxColumn1.Width = 125;
            // 
            // barkodnoDataGridViewTextBoxColumn
            // 
            this.barkodnoDataGridViewTextBoxColumn.DataPropertyName = "barkodno";
            this.barkodnoDataGridViewTextBoxColumn.HeaderText = "barkodno";
            this.barkodnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barkodnoDataGridViewTextBoxColumn.Name = "barkodnoDataGridViewTextBoxColumn";
            this.barkodnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunadiDataGridViewTextBoxColumn
            // 
            this.urunadiDataGridViewTextBoxColumn.DataPropertyName = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.HeaderText = "urunadi";
            this.urunadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunadiDataGridViewTextBoxColumn.Name = "urunadiDataGridViewTextBoxColumn";
            this.urunadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // miktariDataGridViewTextBoxColumn
            // 
            this.miktariDataGridViewTextBoxColumn.DataPropertyName = "miktari";
            this.miktariDataGridViewTextBoxColumn.HeaderText = "miktari";
            this.miktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miktariDataGridViewTextBoxColumn.Name = "miktariDataGridViewTextBoxColumn";
            this.miktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // satisfiyatiDataGridViewTextBoxColumn
            // 
            this.satisfiyatiDataGridViewTextBoxColumn.DataPropertyName = "satisfiyati";
            this.satisfiyatiDataGridViewTextBoxColumn.HeaderText = "satisfiyati";
            this.satisfiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satisfiyatiDataGridViewTextBoxColumn.Name = "satisfiyatiDataGridViewTextBoxColumn";
            this.satisfiyatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamfiyatDataGridViewTextBoxColumn
            // 
            this.toplamfiyatDataGridViewTextBoxColumn.DataPropertyName = "toplamfiyat";
            this.toplamfiyatDataGridViewTextBoxColumn.HeaderText = "toplamfiyat";
            this.toplamfiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamfiyatDataGridViewTextBoxColumn.Name = "toplamfiyatDataGridViewTextBoxColumn";
            this.toplamfiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // sepetBindingSource
            // 
            this.sepetBindingSource.DataMember = "sepet";
            this.sepetBindingSource.DataSource = this.stok_Takip1DataSet3;
            // 
            // stok_Takip1DataSet3
            // 
            this.stok_Takip1DataSet3.DataSetName = "Stok_Takip1DataSet3";
            this.stok_Takip1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sepetTableAdapter
            // 
            this.sepetTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1212, 607);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.btnSatisIptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.müşteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_Takip1DataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_Takip1DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtToplamFiyati;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtMitkari;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private Stok_Takip1DataSet1 stok_Takip1DataSet1;
        private System.Windows.Forms.BindingSource müşteriBindingSource;
        private Stok_Takip1DataSet1TableAdapters.müşteriTableAdapter müşteriTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private EventHandler button8_Click;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Stok_Takip1DataSet3 stok_Takip1DataSet3;
        private System.Windows.Forms.BindingSource sepetBindingSource;
        private Stok_Takip1DataSet3TableAdapters.sepetTableAdapter sepetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}

