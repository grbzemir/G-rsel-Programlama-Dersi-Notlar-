namespace DiziOrnek
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
            this.txt_veri = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lsb_vreriler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eklenecek Veriler :";
            // 
            // txt_veri
            // 
            this.txt_veri.Location = new System.Drawing.Point(60, 95);
            this.txt_veri.Name = "txt_veri";
            this.txt_veri.Size = new System.Drawing.Size(352, 22);
            this.txt_veri.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ekle.Location = new System.Drawing.Point(60, 152);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "eklenen veriler :";
            // 
            // lsb_vreriler
            // 
            this.lsb_vreriler.FormattingEnabled = true;
            this.lsb_vreriler.ItemHeight = 16;
            this.lsb_vreriler.Location = new System.Drawing.Point(63, 259);
            this.lsb_vreriler.Name = "lsb_vreriler";
            this.lsb_vreriler.Size = new System.Drawing.Size(349, 132);
            this.lsb_vreriler.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 444);
            this.Controls.Add(this.lsb_vreriler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_veri);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ListBox Veri Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_veri;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsb_vreriler;
    }
}

