﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Miraç";
            musteri1.Soyadi = "Bayraktar";
            musteri1.TcNo = "1233333333";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "332323";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "122222";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustemerManager custemerManager = new CustemerManager();
            custemerManager.Ekle(musteri1);
            custemerManager.Ekle(musteri2);
           
        }
    }
}
