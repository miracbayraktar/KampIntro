using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemGiris = false;
            double dolarDun = 7.35, dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artiş butonu");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }

            if (sistemGiris==true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap");
            }
            
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            
        }
    }
}
