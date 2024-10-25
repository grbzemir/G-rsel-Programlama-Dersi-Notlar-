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

        private void button1_Click(object sender, EventArgs e)
        {
            liste.Items.Add(txt_ad.Text + " " + txt_soyad.Text + " " + cmb_cinsiyet.Text + " "
                + cmb_durum.Text);
        }
    }
}
