using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] {"Elma", "Karpuz" };

            Product urun1 = new Product();
            urun1.Adi = "Portakal";
            urun1.Fiyati = 7.5;
            urun1.Aciklama = "Washington portakalı";

            Product urun2 = new Product();
            urun2.Adi = "Erik";
            urun2.Fiyati = 40;
            urun2.Aciklama = "Hatay eriği";

            Product[] urunler = new Product[] {urun1, urun2 };

            //type-safe -- tip güvenliği
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("------------------Methods----------------------");
            //instance - örnek
            //encapsulation

            BasketManager sepetManager = new BasketManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 11, 6);
            sepetManager.Ekle2("Elma", "Yeşil elma", 7, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 10, 4);

        }
    }
}
//Method, tekrar tekrar kullanılabilirliği sağlayan prensip sağlar
//Dont repeat yourself - DRY - Clean code - Best Practice