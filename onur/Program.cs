using System;

namespace onur
{
    class Program
    {
        public static void Main(string[] args)
        {
            Icerik urun1 = new Icerik();
            urun1.UrunAdi = "Mayo";
            urun1.UrunFiyati = 112;
            urun1.UrunBedeni = "Medium";

            Icerik urun2 = new Icerik();
            urun2.UrunAdi = "Şort";
            urun2.UrunFiyati = 167;
            urun2.UrunBedeni = "Small";

            Icerik urun3 = new Icerik();
            urun3.UrunAdi = "Tshirt";
            urun3.UrunFiyati = 45;
            urun3.UrunBedeni = "Large";

            Icerik urun4 = new Icerik();
            urun4.UrunAdi = "Havlu";
            urun4.UrunFiyati = 78;
            urun4.UrunBedeni = "Xlarge";

            Icerik urun5 = new Icerik();
            urun5.UrunAdi = "Bikini Altı";
            urun5.UrunFiyati = 67;
            urun5.UrunBedeni = "Medium";

            Icerik[] urunler = new Icerik[] { urun1, urun2, urun3, urun4, urun5 };
            Console.WriteLine("-- Foreach örneği --");
            foreach (var urun in urunler)
            {
                //Console.WriteLine(urun.UrunAdi + " : " + urun.UrunFiyati + " TL " + urun.UrunBedeni);
                Console.WriteLine($"{urun.UrunAdi} : {urun.UrunFiyati} TL {urun.UrunBedeni}");
            }
            Console.WriteLine("-- For örneği --");
            for (int i = 0; i < urunler.Length; i++)
            {
                //Console.WriteLine(urunler[i].UrunAdi + " : " + urunler[i].UrunFiyati + " TL " + urunler[i].UrunBedeni);
                Console.WriteLine($"{urunler[i].UrunAdi} : {urunler[i].UrunFiyati} TL {urunler[i].UrunBedeni}");
            }
            Console.WriteLine("-- While örneği --");
            int x = 0;

            while (x < urunler.Length)
            {
                //Console.WriteLine(urunler[x].UrunAdi + " : " + urunler[x].UrunFiyati + " TL " + urunler[x].UrunBedeni);
                Console.WriteLine($"{urunler[x].UrunAdi} : {urunler[x].UrunFiyati} TL {urunler[x].UrunBedeni}");
                x++;
            }
            Console.WriteLine("Hello World!");
        }
    }
}
// ctrl k f hizalama

