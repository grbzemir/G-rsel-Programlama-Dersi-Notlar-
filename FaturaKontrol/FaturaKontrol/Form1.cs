using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaKontrol
{
    public partial class Form1 : Form
    {
        List<Fatura> faturalar = new List<Fatura>();
        decimal ToplamGelir = 0;
        decimal ToplamGider = 0;
        public Form1()
        {
            InitializeComponent();
            cmbtip.Items.Add("Gelir");
            cmbtip.Items.Add("Gider");
            cmbtip.SelectedIndex = 0;
        }

        private void hesaplaGelirGider()
        {
            ToplamGelir = faturalar.Where(f => f.Tip == "Gelir").Sum(f => f.Tutar);
            ToplamGider = faturalar.Where(f => f.Tip == "Gider").Sum(f => f.Tutar);

            lblGelir.Text = "Toplam Gelir : " + ToplamGelir.ToString("C");
            lblGider.Text = "Toplam Gider : " + ToplamGider.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fatura yenifatura = new Fatura
            {
                Id = faturalar.Count + 1,
                FaturaNo = textBox1.Text,
                Tutar = Convert.ToDecimal(textBox2.Text),
                Tip = cmbtip.SelectedItem.ToString()
            };

            faturalar.Add(yenifatura);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = faturalar;

            hesaplaGelirGider();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Fatura secilenFatura = faturalar.FirstOrDefault(f => f.Id == selectedId);

                if (secilenFatura != null)
                {
                    secilenFatura.FaturaNo = textBox1.Text;
                    secilenFatura.Tutar = Convert.ToDecimal(textBox2.Text);
                    secilenFatura.Tip = cmbtip.SelectedItem.ToString();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = faturalar;
                    hesaplaGelirGider();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Fatura silinenFatura = faturalar.FirstOrDefault(f => f.Id == selectedId);

                if (silinenFatura != null)
                {
                    faturalar.Remove(silinenFatura);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = faturalar;
                    hesaplaGelirGider();

                }
            }
        }
    }
}
