using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOrnegi
{
    public class Sinema
    {
        int toplamkoltuksayisi;
        int boskoltuksayisi;
        double bakiye;
        string salonNo;

        const double TAM = 15.0;
        const double INDIRIMLI = 10.0;

        
         //burası bir yapıcı metot yanı ctor constructor dır!
        public Sinema(string salon, int koltuksayi)
        {
            toplamkoltuksayisi = koltuksayi;
            salonNo = salon;
            boskoltuksayisi = toplamkoltuksayisi;
            bakiye = 0;  
        }
        // Bilet Satış İşlemleri 
        public void BiletSat(bool indirimli)
        {
            boskoltuksayisi--;
            if (indirimli)
                bakiye += INDIRIMLI;
            else
                bakiye += TAM;
        }

        // Bilet İptal olma
        public void  Biletİptal(bool indirimli)
        {
            boskoltuksayisi++;
            if (indirimli)
                bakiye -= INDIRIMLI;
            else
                bakiye -= TAM;
        }
        // bos koltuk sayisi ogren
        public int BoslukOgren()
        {
            return boskoltuksayisi;
        }
        //Bakiye ogren
        public double BakiyeOgren()
        {
            return bakiye;
        }

    }
  
}
