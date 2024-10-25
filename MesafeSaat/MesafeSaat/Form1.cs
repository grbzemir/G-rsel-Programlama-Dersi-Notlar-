using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesafeSaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi;
        int skor;
        private void btn_tahmin_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(textBox1.Text);

            if(tahmin <sayi)
            {
                MessageBox.Show("Yukari");
                skor = skor - 10;
            }
            else if (tahmin >sayi)
            {
                MessageBox.Show("Asagi");
                skor = skor - 10;
            }
            else
            {
                MessageBox.Show("Tebrikler");
            }

            if (skor == 0)
            {
                MessageBox.Show("GAME OVER");
                btn_tahmin.Enabled = false;
            }
            lbl_skor.Text = "Skor : " + skor.ToString();
            textBox1.Clear();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            skor = 100;
            lbl_skor.Text = "Skor : " + skor.ToString();
            btn_tahmin.Enabled = true;
            Random rastgele = new Random();
            sayi = rastgele.Next(101);
            MessageBox.Show("Aklımdan bir Sayı tuttum");
        }
    }
}
