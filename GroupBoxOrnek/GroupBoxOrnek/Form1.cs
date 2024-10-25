using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBoxOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            list_yolcu.Items.Add(txt_ad.Text + " " + txt_soyad.Text + " " + mst_tc.Text + " " + mst_tel.Text +
                " " + cmb_from.Text + " " + cmb_to.Text + " " + mst_tarih.Text + " " + mst_saat.Text);
        }

        private void list_yolcu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
