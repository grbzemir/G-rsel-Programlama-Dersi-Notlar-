using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PlaceHolderOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void txt_ad_Enter(object sender, EventArgs e)        
        {
            if(txt_ad.Text == "Adınızı Giriniz")
            {
                txt_ad.Text = "";
                txt_ad.ForeColor = Color.Black;
            }

        }

        private void txt_ad_Leave(object sender, EventArgs e)
        {
            if(txt_ad.Text =="")
            {
                txt_ad.Text = "Adınızı Giriniz";
                txt_ad.ForeColor = Color.LightGray;
            }
        }

        private void txt_soyad_Enter(object sender, EventArgs e)
        {
            if (txt_soyad.Text == "Soyadınızı Giriniz")
            {
                txt_soyad.Text = "";
                txt_soyad.ForeColor = Color.Black;
            }
        }

        private void txt_soyad_Leave(object sender, EventArgs e)
        {
            if (txt_soyad.Text == "")
            {
                txt_soyad.Text = "Soydınızı Giriniz";
                txt_soyad.ForeColor = Color.LightGray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_ad.Text = "Adınızı Giriniz";
            txt_soyad.Text = "Soyadınızı Giriniz";
            txt_ad.ForeColor = Color.LightGray;
            txt_soyad.ForeColor = Color.LightGray;
        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
