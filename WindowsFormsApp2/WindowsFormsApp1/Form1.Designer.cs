namespace WindowsFormsApp1
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
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.lbl_alan = new System.Windows.Forms.Label();
            this.lbl_cevre = new System.Windows.Forms.Label();
            this.rbl_alan = new System.Windows.Forms.RadioButton();
            this.rbl_cevre = new System.Windows.Forms.RadioButton();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kısa Kenar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uzun Kenar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(332, 176);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(75, 23);
            this.btn_hesapla.TabIndex = 4;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // lbl_alan
            // 
            this.lbl_alan.AutoSize = true;
            this.lbl_alan.Location = new System.Drawing.Point(367, 91);
            this.lbl_alan.Name = "lbl_alan";
            this.lbl_alan.Size = new System.Drawing.Size(0, 16);
            this.lbl_alan.TabIndex = 5;
            // 
            // lbl_cevre
            // 
            this.lbl_cevre.AutoSize = true;
            this.lbl_cevre.Location = new System.Drawing.Point(367, 129);
            this.lbl_cevre.Name = "lbl_cevre";
            this.lbl_cevre.Size = new System.Drawing.Size(0, 16);
            this.lbl_cevre.TabIndex = 6;
            // 
            // rbl_alan
            // 
            this.rbl_alan.AutoSize = true;
            this.rbl_alan.Location = new System.Drawing.Point(332, 88);
            this.rbl_alan.Name = "rbl_alan";
            this.rbl_alan.Size = new System.Drawing.Size(55, 20);
            this.rbl_alan.TabIndex = 7;
            this.rbl_alan.TabStop = true;
            this.rbl_alan.Text = "Alan";
            this.rbl_alan.UseVisualStyleBackColor = true;
            this.rbl_alan.CheckedChanged += new System.EventHandler(this.rbl_alan_CheckedChanged);
            // 
            // rbl_cevre
            // 
            this.rbl_cevre.AutoSize = true;
            this.rbl_cevre.Location = new System.Drawing.Point(332, 129);
            this.rbl_cevre.Name = "rbl_cevre";
            this.rbl_cevre.Size = new System.Drawing.Size(64, 20);
            this.rbl_cevre.TabIndex = 8;
            this.rbl_cevre.TabStop = true;
            this.rbl_cevre.Text = "Cevre";
            this.rbl_cevre.UseVisualStyleBackColor = true;
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(178, 223);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(0, 16);
            this.lbl_sonuc.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 291);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.rbl_cevre);
            this.Controls.Add(this.rbl_alan);
            this.Controls.Add(this.lbl_cevre);
            this.Controls.Add(this.lbl_alan);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label lbl_alan;
        private System.Windows.Forms.Label lbl_cevre;
        private System.Windows.Forms.RadioButton rbl_alan;
        private System.Windows.Forms.RadioButton rbl_cevre;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

