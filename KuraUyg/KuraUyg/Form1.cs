using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuraUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (textBox1 != null)
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void btn_aktar_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Int32.Parse(textBox2.Text);
                Random rnd = new Random();

                for(int i = 1; i<=sayi; i++)
                {
                    int tutulan = rnd.Next(0, listBox1.Items.Count); // listBox1 in içindeki değerlere kadar!
                    listBox2.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.Remove(tutulan);
                }
            }catch
            {
                MessageBox.Show("Bilgileri Kontrol edin...");
            }
        }

        private void btn_esle_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int kisiSayisi = listBox1.Items.Count;

            for(int i = 1; i<=kisiSayisi; i++)
            {
                int tutulan = rnd.Next(0, listBox1.Items.Count);
                
                if(i%2 == 1) // eşit dağılıtcağı manasına gelir!
                {
                    listBox2.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
                else
                {
                    listBox3.Items.Add(listBox1.Items[tutulan]);
                    listBox1.Items.RemoveAt(tutulan);
                }
            }


        }
    }
}
