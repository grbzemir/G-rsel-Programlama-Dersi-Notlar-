using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notOrtalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            string ad, soyad;
            int ogrno;

            ad = textBox1.Text;
            soyad = textBox2.Text;
            ogrno = Convert.ToInt16(textBox3.Text);

            vize = Convert.ToDouble(txt_vize.Text);
            final = Convert.ToDouble(txt_final.Text);

            ortalama = (vize * 0.3) + (final * 0.7);

            listBox1.Items.Add(ad + " " + soyad + " " + "Ortalama :" + ortalama);

            if(ortalama >=50)
            {
                lbl_durum.Text = "Geçtiniz...";
            }
            else
            {
                lbl_durum.Text = "Kaldınız";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
