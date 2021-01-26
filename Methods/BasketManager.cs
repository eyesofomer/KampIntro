using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        //naming convention - isimlendirme kuralı
        //syntax
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + urun.Adi+" "+ urun.Fiyati);
        }

        public void Ekle2(string urunAdi, string Aciklama, double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + urunAdi);
        }

    }
}
