using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOrnegi
{
    public partial class Form1 : Form
    {
        private Sinema salon;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            try
            {
                salon = new Sinema(textBox1.Text, Convert.ToInt32(textBox2.Text));
                label3.Text = "Salon Olusturuldu, Koltuk Sayisi : " + salon.BoslukOgren();
            }
            catch
            {
                label3.Text = "Salon Olusturulamadi" +
                    "Girdiğiniz bilgileri kontrol ediniz";
            }
            
        }

        private void btn_sat_Click(object sender, EventArgs e)
        {
            salon.BiletSat(chbx1.Checked);
            label3.Text = "Bilet Satıldı, kalan koltuk sayisi : " + salon.BoslukOgren();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            salon.Biletİptal(chbx1.Checked);
            label3.Text = "Bilet iptal edildi, kalan koltuk sayisi : " + salon.BoslukOgren();

        }

        private void btn_bakiye_Click(object sender, EventArgs e)
        {
            label3.Text = "Mevcut Bakiye : " + salon.BakiyeOgren() + "TL.";
        }

        private void btn_bos_Click(object sender, EventArgs e)
        {
            label3.Text = "Bos Koltuk Sayisi : " + salon.BoslukOgren();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
