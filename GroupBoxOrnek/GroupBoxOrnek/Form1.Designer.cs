namespace GroupBoxOrnek
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mst_tel = new System.Windows.Forms.MaskedTextBox();
            this.mst_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mst_saat = new System.Windows.Forms.MaskedTextBox();
            this.mst_tarih = new System.Windows.Forms.MaskedTextBox();
            this.cmb_to = new System.Windows.Forms.ComboBox();
            this.cmb_from = new System.Windows.Forms.ComboBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.list_yolcu = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mst_tel);
            this.groupBox1.Controls.Add(this.mst_tc);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(381, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yolcu Bilgileri";
            // 
            // mst_tel
            // 
            this.mst_tel.Location = new System.Drawing.Point(72, 185);
            this.mst_tel.Margin = new System.Windows.Forms.Padding(4);
            this.mst_tel.Mask = "(999) 000-0000";
            this.mst_tel.Name = "mst_tel";
            this.mst_tel.Size = new System.Drawing.Size(223, 22);
            this.mst_tel.TabIndex = 7;
            // 
            // mst_tc
            // 
            this.mst_tc.Location = new System.Drawing.Point(72, 144);
            this.mst_tc.Margin = new System.Windows.Forms.Padding(4);
            this.mst_tc.Mask = "0000000000";
            this.mst_tc.Name = "mst_tc";
            this.mst_tc.Size = new System.Drawing.Size(223, 22);
            this.mst_tc.TabIndex = 6;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(72, 95);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(223, 22);
            this.txt_soyad.TabIndex = 5;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(72, 43);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(223, 22);
            this.txt_ad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mst_saat);
            this.groupBox2.Controls.Add(this.mst_tarih);
            this.groupBox2.Controls.Add(this.cmb_to);
            this.groupBox2.Controls.Add(this.cmb_from);
            this.groupBox2.Controls.Add(this.btn_kaydet);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(447, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(381, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sefer Bilgileri";
            // 
            // mst_saat
            // 
            this.mst_saat.Location = new System.Drawing.Point(117, 175);
            this.mst_saat.Margin = new System.Windows.Forms.Padding(4);
            this.mst_saat.Mask = "00:00";
            this.mst_saat.Name = "mst_saat";
            this.mst_saat.Size = new System.Drawing.Size(160, 22);
            this.mst_saat.TabIndex = 8;
            this.mst_saat.ValidatingType = typeof(System.DateTime);
            // 
            // mst_tarih
            // 
            this.mst_tarih.Location = new System.Drawing.Point(117, 134);
            this.mst_tarih.Margin = new System.Windows.Forms.Padding(4);
            this.mst_tarih.Mask = "00/00/0000";
            this.mst_tarih.Name = "mst_tarih";
            this.mst_tarih.Size = new System.Drawing.Size(160, 22);
            this.mst_tarih.TabIndex = 7;
            this.mst_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_to
            // 
            this.cmb_to.FormattingEnabled = true;
            this.cmb_to.Items.AddRange(new object[] {
            "Edirne",
            "Tekirdağ",
            "Kırklareli",
            "İstanbul",
            "Bursa ",
            "Çanakkale",
            "Ankara",
            "İzmir",
            "Antalya",
            "Balıkesir"});
            this.cmb_to.Location = new System.Drawing.Point(117, 87);
            this.cmb_to.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_to.Name = "cmb_to";
            this.cmb_to.Size = new System.Drawing.Size(160, 24);
            this.cmb_to.TabIndex = 6;
            // 
            // cmb_from
            // 
            this.cmb_from.FormattingEnabled = true;
            this.cmb_from.Items.AddRange(new object[] {
            "Edirne",
            "Tekirdağ",
            "Kırklareli",
            "İstanbul",
            "Bursa ",
            "Çanakkale",
            "Ankara",
            "İzmir",
            "Antalya",
            "Balıkesir"});
            this.cmb_from.Location = new System.Drawing.Point(117, 32);
            this.cmb_from.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_from.Name = "cmb_from";
            this.cmb_from.Size = new System.Drawing.Size(160, 24);
            this.cmb_from.TabIndex = 5;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(273, 228);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(100, 28);
            this.btn_kaydet.TabIndex = 4;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Saat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tarhi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nereye";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nereden";
            // 
            // list_yolcu
            // 
            this.list_yolcu.FormattingEnabled = true;
            this.list_yolcu.ItemHeight = 16;
            this.list_yolcu.Location = new System.Drawing.Point(121, 369);
            this.list_yolcu.Margin = new System.Windows.Forms.Padding(4);
            this.list_yolcu.Name = "list_yolcu";
            this.list_yolcu.Size = new System.Drawing.Size(603, 148);
            this.list_yolcu.TabIndex = 2;
            this.list_yolcu.SelectedIndexChanged += new System.EventHandler(this.list_yolcu_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 622);
            this.Controls.Add(this.list_yolcu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox list_yolcu;
        private System.Windows.Forms.MaskedTextBox mst_tel;
        private System.Windows.Forms.MaskedTextBox mst_tc;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.MaskedTextBox mst_saat;
        private System.Windows.Forms.MaskedTextBox mst_tarih;
        private System.Windows.Forms.ComboBox cmb_to;
        private System.Windows.Forms.ComboBox cmb_from;
    }
}

