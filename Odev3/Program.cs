using System;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriAdi = "Miraç";
            musteri.MusteriSoyad = "Bayraktar";
            musteri.Tckimlik = "2222222222222";
            musteri.Telefon = "8787878787";
            musteri.Para = 17650;
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Sil(musteri);
            musteriManager.Listeleme(musteri);
        }
    }
}
