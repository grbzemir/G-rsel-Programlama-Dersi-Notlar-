using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class Form1 : Form
    {
        //Dictionary anahtar değer çift uyumları için kullanılmaktadır.

        private Dictionary<string, string> kullanicilar = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string user_name = registerusername.Text;
            string password = registerpassword.Text;

            if (string.IsNullOrEmpty(user_name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz");
                return;
            }
            if (kullanicilar.ContainsKey(user_name))
            {
                MessageBox.Show("Bu Kullanici adi zaten var");
            }
            else 
            { 
                kullanicilar.Add(user_name, password);
                MessageBox.Show("Kayıt Başarılı");
                registerusername.Clear();
                registerpassword.Clear();
            }
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = loginusernme.Text;
            string password = loginpassword.Text;

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz");
                return;
            }

            if (kullanicilar.ContainsKey((string)username) && kullanicilar[username] == password)
            {
                MessageBox.Show("Giris Basarili");
                loginusernme.Clear();   
                loginpassword.Clear();
            }
            else
            {
                MessageBox.Show("Kullanici adi veya şifre hatali");
            }
        }
    }
}
