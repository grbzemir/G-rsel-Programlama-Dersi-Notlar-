using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuKayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Randevu randevu;
        BindingList<Randevu> liste = new BindingList<Randevu>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox a poliklinik eklenmesi
            string[] poliklinikler =
            {
                "Kardiyoloji", "Dahiliye","Ortopedi", "Göz Hastaliklari","Dermotoloji","Kulak Burun Boğaz",
                "Diş","Nöroloji","Üroloji","Genel Cerrahi","Onkoloji","Fizik Tedavi"
            };
            //combobox a aktar 
            cmb_pol.Items.AddRange(poliklinikler);

            liste.Add(new Randevu(1, "Egemen Tekkanat", "5335765806", "Diş", new DateTime(2024, 11, 01), true));
            liste.Add(new Randevu(2, "Murat Topaloğlu", "5335765806", "Ortopedi\"", new DateTime(2024, 11, 01), false));
            liste.Add(new Randevu(3, "Harun Özkişi", "5335765806", "Diş", new DateTime(2024, 11, 01), true));
            liste.Add(new Randevu(4, "Onur Kara", "5335765806", "Onkoloji", new DateTime(2024, 11, 01), true));
            liste.Add(new Randevu(5, "Duygu Solak", "5335765806", "Fizik Tedavi", new DateTime(2024, 11, 01), false));

            dataGridView1.DataSource = liste.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                txtadsoyad.Text = dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString();
                txttel.Text = dataGridView1.CurrentRow.Cells["tel"].Value.ToString();
                cmb_pol.Text = dataGridView1.CurrentRow.Cells["poliklinik"].Value.ToString();
                chk_sigorta.Checked = (Boolean)dataGridView1.CurrentRow.Cells["sigorta"].Value;
                dtp_tarih.Value = (DateTime)dataGridView1.CurrentRow.Cells["tarih"].Value;
            }
            catch
            {
                throw;
            }

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string adsoyad = txtadsoyad.Text;
            string telefon = txttel.Text;
            string poliklinik = cmb_pol.Text;
            DateTime tarih = dtp_tarih.Value;
            bool sigorta = chk_sigorta.Checked;

            //bilgileri form elemanlardan aldık, kayıt edelim

            Randevu yeniRandevu = new Randevu(id, adsoyad, telefon, poliklinik, tarih, sigorta);

            liste.Add(yeniRandevu);

            dataGridView1.DataSource = liste.ToList();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                // seçili satır var ise bu satırdan veriyi alalım
                DataGridViewRow secilenSatir = dataGridView1.SelectedRows[0];

                // secilemn satıra ulaşarak bunu randevu türüne çevirelim.
                Randevu secilenRandevu = secilenSatir.DataBoundItem as Randevu;

                if (secilenRandevu != null)
                {
                    if (liste.Contains(secilenRandevu))
                    {
                        liste.Remove(secilenRandevu);
                    }
                }
            }
            dataGridView1.DataSource = liste.ToList();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            // seçili satır var ise bu satırdan veriyi alalım
            DataGridViewRow secilenSatir = dataGridView1.SelectedRows[0];

            // secilemn satıra ulaşarak bunu randevu türüne çevirelim.
            Randevu secilenRandevu = secilenSatir.DataBoundItem as Randevu;

            if(secilenRandevu != null)
            {
                // yeni değerleri kullanarak güncelleyelim
                int id = Convert.ToInt32(txtId.Text);
                string adsoyad = txtadsoyad.Text;
                string telefon = txttel.Text;
                string poliklinik = cmb_pol.Text;
                DateTime tarih = dtp_tarih.Value;
                bool sigorta = chk_sigorta.Checked;

                secilenRandevu.Adsoyad = adsoyad;   
                secilenRandevu.Id = id;
                secilenRandevu.Tarih = tarih;
                secilenRandevu.Poliklinik = poliklinik;
                secilenRandevu.Sigorta = sigorta;
                secilenRandevu.Telefon = telefon;

                // Datagridview i güncelle
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = liste.ToList();

            }
        }
    }
}
