using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelistirme Kursu";
            string kurs2 = "Programlamaya Baslangıç Kursu";
            string kurs3 = "Java Kursu";

            string[] kurslar = new string[] { "Yazılım Gelistirme Kursu", "Programlamaya Baslangıç Kursu", "Java Kursu" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu-footer");

        }
    }
}
