using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[]
            {
               "deneme",
               "deneme2",
               "deneme3"
            };

            Console.WriteLine("for bitti");

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
        }

    }
}
