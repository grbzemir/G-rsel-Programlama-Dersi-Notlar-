namespace SinemaOrnegi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_olustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_sat = new System.Windows.Forms.Button();
            this.chbx1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_bos = new System.Windows.Forms.Button();
            this.btn_bakiye = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Koltuk Sayisi :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_olustur
            // 
            this.btn_olustur.Location = new System.Drawing.Point(352, 72);
            this.btn_olustur.Name = "btn_olustur";
            this.btn_olustur.Size = new System.Drawing.Size(191, 65);
            this.btn_olustur.TabIndex = 4;
            this.btn_olustur.Text = "Olustur";
            this.btn_olustur.UseVisualStyleBackColor = true;
            this.btn_olustur.Click += new System.EventHandler(this.btn_olustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_iptal);
            this.groupBox1.Controls.Add(this.btn_sat);
            this.groupBox1.Controls.Add(this.chbx1);
            this.groupBox1.Location = new System.Drawing.Point(42, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 149);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satıs İşlemleri";
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(122, 80);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(89, 49);
            this.btn_iptal.TabIndex = 2;
            this.btn_iptal.Text = "Bilet İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_sat
            // 
            this.btn_sat.Location = new System.Drawing.Point(17, 81);
            this.btn_sat.Name = "btn_sat";
            this.btn_sat.Size = new System.Drawing.Size(86, 48);
            this.btn_sat.TabIndex = 1;
            this.btn_sat.Text = "Bilet Satış";
            this.btn_sat.UseVisualStyleBackColor = true;
            this.btn_sat.Click += new System.EventHandler(this.btn_sat_Click);
            // 
            // chbx1
            // 
            this.chbx1.AutoSize = true;
            this.chbx1.Location = new System.Drawing.Point(17, 38);
            this.chbx1.Name = "chbx1";
            this.chbx1.Size = new System.Drawing.Size(74, 20);
            this.chbx1.TabIndex = 0;
            this.chbx1.Text = "İndirimli";
            this.chbx1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_bos);
            this.groupBox2.Controls.Add(this.btn_bakiye);
            this.groupBox2.Location = new System.Drawing.Point(370, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 139);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Raporlama";
            // 
            // btn_bos
            // 
            this.btn_bos.Location = new System.Drawing.Point(130, 39);
            this.btn_bos.Name = "btn_bos";
            this.btn_bos.Size = new System.Drawing.Size(126, 63);
            this.btn_bos.TabIndex = 1;
            this.btn_bos.Text = "Boş Koltuk";
            this.btn_bos.UseVisualStyleBackColor = true;
            this.btn_bos.Click += new System.EventHandler(this.btn_bos_Click);
            // 
            // btn_bakiye
            // 
            this.btn_bakiye.Location = new System.Drawing.Point(6, 39);
            this.btn_bakiye.Name = "btn_bakiye";
            this.btn_bakiye.Size = new System.Drawing.Size(118, 63);
            this.btn_bakiye.TabIndex = 0;
            this.btn_bakiye.Text = "Bakiye ";
            this.btn_bakiye.UseVisualStyleBackColor = true;
            this.btn_bakiye.Click += new System.EventHandler(this.btn_bakiye_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 421);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_olustur);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_olustur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbx1;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_sat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_bos;
        private System.Windows.Forms.Button btn_bakiye;
        private System.Windows.Forms.Label label3;
    }
}

