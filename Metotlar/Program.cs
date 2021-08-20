using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Aciklama = "martini içi";
            urun1.Fiyati = 15;
            urun1.Id = 1;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır";
            urun2.Fiyati = 100;
            urun2.Id = 2;

            Urun[] urunler = new Urun[] {
                urun1, urun2
            };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
            }

            Console.WriteLine("------------------------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        }
    }
}
