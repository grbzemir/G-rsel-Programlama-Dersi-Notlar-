using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable tablo = new DataTable();

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //rows satır demek!
            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablo;

            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            label4.Text = toplam.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Columns sutun demek!
            tablo.Columns.Add("ID", typeof(int));
            tablo.Columns.Add("GIDER", typeof(string));
            tablo.Columns.Add("TUTAR", typeof(int));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tablo;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            // kayıt varsa silsin
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lütfen Silinecek satırı seçiniz");
            }
        }
    }
}
