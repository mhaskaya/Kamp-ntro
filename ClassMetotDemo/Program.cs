using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Mila = new Musteri();
            Mila.Id = 11;
            Mila.Adi = "Mila";
            Mila.Soyadi = "Somuncuoğlu";
            Mila.Yas = 3;
            Mila.Sehir = "İstanbul";

            Musteri Simay = new Musteri();
            Simay.Id = 28;
            Simay.Adi = "Simay";
            Simay.Soyadi = "Haskaya";
            Simay.Yas = 35;
            Simay.Sehir = "İstanbul";

            Musteri Serhat = new Musteri();
            Serhat.Id = 98;
            Serhat.Adi = "Serhat";
            Serhat.Soyadi = "Haskaya";
            Serhat.Yas = 33;
            Serhat.Sehir = "Sivas";

            Musteri Gulseren = new Musteri();
            Gulseren.Id = 47;
            Gulseren.Adi = "Gülseren";
            Gulseren.Soyadi = "Yurtaslan";
            Gulseren.Yas = 65;
            Gulseren.Sehir = "Bükreş";

            Musteri Semistan = new Musteri();
            Semistan.Id = 789;
            Semistan.Adi = "Şemistan";
            Semistan.Soyadi = "Yurtaslan";
            Semistan.Yas = 61;
            Semistan.Sehir = "Muğla";

            Musteri[] musteriler = new Musteri[] { Mila, Simay, Serhat, Gulseren, Semistan };


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(Mila);
            musteriManager.Ekle(Simay);
            musteriManager.Ekle(Serhat);
            musteriManager.Ekle(Gulseren);
            musteriManager.Ekle(Semistan);

            musteriManager.Sil(Mila);
            musteriManager.Sil(Simay);
            musteriManager.Sil(Serhat);
            musteriManager.Sil(Gulseren);
            musteriManager.Sil(Semistan);

            musteriManager.MusteriListele(musteriler);
        }
    }
}
