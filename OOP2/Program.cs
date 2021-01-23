using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Miray HASKAYA
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "74185";
            musteri1.Adi = "Miray";
            musteri1.Soyadi = "Haskaya";
            musteri1.TcNo = "741852960";
            musteri1.Id = 7;


            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "7418596";
            musteri2.VergiNo = "9785443";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.Id = 5;

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);


        }
    }
}
