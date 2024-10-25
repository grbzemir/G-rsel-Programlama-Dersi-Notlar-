using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int kisakenar, uzunkenar, sonuc=0;
            kisakenar = Convert.ToInt32(textBox1.Text);
            uzunkenar = Convert.ToInt32(textBox2.Text);

            //dikdörgen alanı hesaplamak için formüller

            if (rbl_alan.Checked)
                sonuc = kisakenar * uzunkenar;
            else if (rbl_cevre.Checked)
                sonuc = 2 * (kisakenar + uzunkenar);
            else
                MessageBox.Show("lütfen hesaplamak istediğiniz birimi işaretleyiniz");

            lbl_sonuc.Text = "Sonuc : " + sonuc;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbl_alan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
