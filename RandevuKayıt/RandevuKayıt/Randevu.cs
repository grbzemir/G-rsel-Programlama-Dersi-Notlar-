using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuKayıt
{
    public class Randevu
    {
        int id;
        string adsoyad;
        string telefon;
        string poliklinik;
        DateTime tarih;
        bool sigorta;

        public int Id { get => id; set =>id = value; }
        public string Adsoyad {  get => adsoyad; set => adsoyad = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Poliklinik { get => poliklinik; set => poliklinik = value; }
        public bool Sigorta { get => sigorta;   set => sigorta = value; }
        public  DateTime Tarih { get => tarih; set => tarih = value; }

        public Randevu(int id, string adsoyad, string telefon, string poliklinik, DateTime tarih, bool sigorta)
        {
            this.id = id;
            this.adsoyad = adsoyad;
            this.telefon = telefon; 
            this.poliklinik = poliklinik;
            this.tarih = tarih;
            this.sigorta = sigorta;
        }
        
    }
}
