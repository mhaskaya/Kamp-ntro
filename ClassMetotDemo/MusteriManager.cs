using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri Eklendi : " + musteri.Adi + musteri.Soyadi + musteri.Id);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi +  musteri.Soyadi + " : Müsteri Silindi!");

        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " numaralı müşteri : " + musteri.Adi);
            }




        }
    }
}
