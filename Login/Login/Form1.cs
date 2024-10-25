using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 yeni_form =new Form2();

        private void btn_login_Click(object sender, EventArgs e)
        {
            string k_adi = "egementekkanat";
            string sifre = "123ege";

            if (k_adi == txt_user.Text && sifre == txt_password.Text)
            {
                MessageBox.Show("Giris Basarili");
                yeni_form.Show();
            }
            else
                MessageBox.Show("Hatalı kullanici adı veya sifre");
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
