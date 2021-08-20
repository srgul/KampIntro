using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.EğitmenAdi = "Sait";
            kurs1.izlenmeOranı = 50;

            Kurs kurs2 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.EğitmenAdi = "ramazan";
            kurs1.izlenmeOranı = 50;

            Kurs kurs3 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.EğitmenAdi = "gül";
            kurs1.izlenmeOranı = 50;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.EğitmenAdi);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string EğitmenAdi { get; set; }

        public int izlenmeOranı { get; set; }
    }
}
