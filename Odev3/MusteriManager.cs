using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Bankaya Eklendi :" + musteri.MusteriAdi + " " + musteri.MusteriSoyad + " " + musteri.Tckimlik + " " + musteri.Telefon + " " + musteri.Para);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi");
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi:" + musteri.MusteriAdi + " " + musteri.MusteriSoyad + " " + musteri.Tckimlik + " " + musteri.Telefon + " " + musteri.Para);
        }
    }
}
