﻿namespace EntityFramework
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnOListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtOId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFoto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDersId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDersAd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSinavGuncelle = new System.Windows.Forms.Button();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.TxtOrt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.TxtSinav3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.BtnDListele = new System.Windows.Forms.Button();
            this.BtnNListele = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            this.BtnBul1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BtnLinqEntity = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(817, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnOListele
            // 
            this.BtnOListele.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOListele.Location = new System.Drawing.Point(12, 209);
            this.BtnOListele.Name = "BtnOListele";
            this.BtnOListele.Size = new System.Drawing.Size(157, 34);
            this.BtnOListele.TabIndex = 1;
            this.BtnOListele.Text = "Öğrenci Listele";
            this.BtnOListele.UseVisualStyleBackColor = true;
            this.BtnOListele.Click += new System.EventHandler(this.BtnOListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKaydet.Location = new System.Drawing.Point(12, 249);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(157, 34);
            this.BtnKaydet.TabIndex = 1;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSil.Location = new System.Drawing.Point(12, 289);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(157, 34);
            this.BtnSil.TabIndex = 1;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuncelle.Location = new System.Drawing.Point(12, 329);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(157, 34);
            this.BtnGuncelle.TabIndex = 1;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.button2_Click);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(74, 45);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(23, 16);
            this.LblId.TabIndex = 2;
            this.LblId.Text = "ID:";
            // 
            // TxtOId
            // 
            this.TxtOId.Location = new System.Drawing.Point(103, 42);
            this.TxtOId.Name = "TxtOId";
            this.TxtOId.Size = new System.Drawing.Size(140, 22);
            this.TxtOId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "AD:";
            // 
            // TxtOAd
            // 
            this.TxtOAd.Location = new System.Drawing.Point(103, 75);
            this.TxtOAd.Name = "TxtOAd";
            this.TxtOAd.Size = new System.Drawing.Size(140, 22);
            this.TxtOAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SOYAD:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtOSoyad
            // 
            this.TxtOSoyad.Location = new System.Drawing.Point(103, 106);
            this.TxtOSoyad.Name = "TxtOSoyad";
            this.TxtOSoyad.Size = new System.Drawing.Size(140, 22);
            this.TxtOSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "FOTOĞRAF:";
            // 
            // TxtFoto
            // 
            this.TxtFoto.Location = new System.Drawing.Point(103, 136);
            this.TxtFoto.Name = "TxtFoto";
            this.TxtFoto.Size = new System.Drawing.Size(140, 22);
            this.TxtFoto.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtFoto);
            this.groupBox1.Controls.Add(this.LblId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtOId);
            this.groupBox1.Controls.Add(this.TxtOSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtOAd);
            this.groupBox1.Location = new System.Drawing.Point(261, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 215);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogrenci";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtDersId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtDersAd);
            this.groupBox2.Location = new System.Drawing.Point(548, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 215);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dersler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID:";
            // 
            // TxtDersId
            // 
            this.TxtDersId.Location = new System.Drawing.Point(86, 73);
            this.TxtDersId.Name = "TxtDersId";
            this.TxtDersId.Size = new System.Drawing.Size(140, 22);
            this.TxtDersId.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "AD:";
            // 
            // TxtDersAd
            // 
            this.TxtDersAd.Location = new System.Drawing.Point(86, 106);
            this.TxtDersAd.Name = "TxtDersAd";
            this.TxtDersAd.Size = new System.Drawing.Size(140, 22);
            this.TxtDersAd.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSinavGuncelle);
            this.groupBox3.Controls.Add(this.BtnHesapla);
            this.groupBox3.Controls.Add(this.TxtDurum);
            this.groupBox3.Controls.Add(this.TxtOrt);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtSinav1);
            this.groupBox3.Controls.Add(this.TxtSinav3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TxtSinav2);
            this.groupBox3.Location = new System.Drawing.Point(261, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 274);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // BtnSinavGuncelle
            // 
            this.BtnSinavGuncelle.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSinavGuncelle.Location = new System.Drawing.Point(16, 232);
            this.BtnSinavGuncelle.Name = "BtnSinavGuncelle";
            this.BtnSinavGuncelle.Size = new System.Drawing.Size(227, 34);
            this.BtnSinavGuncelle.TabIndex = 10;
            this.BtnSinavGuncelle.Text = "Sınav Notu Güncelle";
            this.BtnSinavGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHesapla.Location = new System.Drawing.Point(103, 192);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(140, 34);
            this.BtnHesapla.TabIndex = 9;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(103, 164);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(140, 22);
            this.TxtDurum.TabIndex = 3;
            // 
            // TxtOrt
            // 
            this.TxtOrt.Location = new System.Drawing.Point(103, 136);
            this.TxtOrt.Name = "TxtOrt";
            this.TxtOrt.Size = new System.Drawing.Size(140, 22);
            this.TxtOrt.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "DURUM:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "SINAV1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "ORTALAMA:";
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Location = new System.Drawing.Point(103, 42);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(140, 22);
            this.TxtSinav1.TabIndex = 3;
            // 
            // TxtSinav3
            // 
            this.TxtSinav3.Location = new System.Drawing.Point(103, 106);
            this.TxtSinav3.Name = "TxtSinav3";
            this.TxtSinav3.Size = new System.Drawing.Size(140, 22);
            this.TxtSinav3.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "SINAV2:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "SINAV3:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Location = new System.Drawing.Point(103, 75);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(140, 22);
            this.TxtSinav2.TabIndex = 3;
            // 
            // BtnDListele
            // 
            this.BtnDListele.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDListele.Location = new System.Drawing.Point(12, 410);
            this.BtnDListele.Name = "BtnDListele";
            this.BtnDListele.Size = new System.Drawing.Size(157, 33);
            this.BtnDListele.TabIndex = 7;
            this.BtnDListele.Text = "Ders Listele";
            this.BtnDListele.UseVisualStyleBackColor = true;
            this.BtnDListele.Click += new System.EventHandler(this.BtnDListele_Click);
            // 
            // BtnNListele
            // 
            this.BtnNListele.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNListele.Location = new System.Drawing.Point(12, 450);
            this.BtnNListele.Name = "BtnNListele";
            this.BtnNListele.Size = new System.Drawing.Size(157, 33);
            this.BtnNListele.TabIndex = 8;
            this.BtnNListele.Text = "Not Listele";
            this.BtnNListele.UseVisualStyleBackColor = true;
            this.BtnNListele.Click += new System.EventHandler(this.BtnNListele_Click);
            // 
            // btnProc
            // 
            this.btnProc.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnProc.Location = new System.Drawing.Point(12, 490);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(225, 31);
            this.btnProc.TabIndex = 9;
            this.btnProc.Text = "Not Listesi(Proc)";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // BtnBul1
            // 
            this.BtnBul1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold);
            this.BtnBul1.Location = new System.Drawing.Point(12, 369);
            this.BtnBul1.Name = "BtnBul1";
            this.BtnBul1.Size = new System.Drawing.Size(157, 30);
            this.BtnBul1.TabIndex = 10;
            this.BtnBul1.Text = "Bul";
            this.BtnBul1.UseVisualStyleBackColor = true;
            this.BtnBul1.Click += new System.EventHandler(this.BtnBul1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(853, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(163, 20);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ada Göre Sırala (A->Z)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BtnLinqEntity
            // 
            this.BtnLinqEntity.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLinqEntity.Location = new System.Drawing.Point(841, 490);
            this.BtnLinqEntity.Name = "BtnLinqEntity";
            this.BtnLinqEntity.Size = new System.Drawing.Size(157, 34);
            this.BtnLinqEntity.TabIndex = 12;
            this.BtnLinqEntity.Text = "Linq Entity";
            this.BtnLinqEntity.UseVisualStyleBackColor = true;
            this.BtnLinqEntity.Click += new System.EventHandler(this.BtnLinqEntity_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(853, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(163, 20);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ada Göre Sırala (Z->A)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(853, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(83, 20);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "İlk 3 Kayıt";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(853, 91);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(93, 20);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "1 Id yi Getir";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(853, 117);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(113, 20);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Like ile Arama";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(853, 143);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(153, 20);
            this.radioButton6.TabIndex = 17;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Adı O ile Başlayanlar";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(853, 169);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(125, 20);
            this.radioButton7.TabIndex = 18;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Adı T ile Bitenler";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(853, 195);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(114, 20);
            this.radioButton8.TabIndex = 19;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Değer Var Mı?";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(853, 221);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(165, 20);
            this.radioButton9.TabIndex = 20;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Toplam Öğrenci Sayısı";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(851, 247);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(153, 20);
            this.radioButton10.TabIndex = 21;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Sınav1 Toplam Puan";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(851, 273);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(161, 20);
            this.radioButton11.TabIndex = 22;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Sınav1 Ortalama Puan";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(851, 299);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(215, 20);
            this.radioButton12.TabIndex = 23;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Sınav1 Ortalamasından Yüksek";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Notları Join ile Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 724);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.BtnLinqEntity);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnBul1);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.BtnNListele);
            this.Controls.Add(this.BtnDListele);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnOListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnOListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtOId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDersId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDersAd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.TextBox TxtOrt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.TextBox TxtSinav3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.Button BtnDListele;
        private System.Windows.Forms.Button BtnNListele;
        private System.Windows.Forms.Button BtnSinavGuncelle;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Button BtnBul1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button BtnLinqEntity;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.Button button1;
    }
}

