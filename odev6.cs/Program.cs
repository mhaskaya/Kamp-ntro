using System;

namespace odev6.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Icerik urun1 = new Urun();
            urun1.UrunAdi = "Mayo";
            urun1.UrunFiyati = 112;
            urun1.UrunBedeni = "Medium";

            Icerik urun2 = new Urun();
            urun2.UrunAdi = "Şort";
            urun2.UrunFiyati = 167;
            urun2.UrunBedeni = "Small";

            Icerik urun3 = new Urun();
            urun3.UrunAdi = "Tshirt";
            urun3.UrunFiyati = 45;
            urun3.UrunBedeni = "Large";

            Icerik urun4 = new Urun();
            urun4.UrunAdi = "Havlu";
            urun4.UrunFiyati = 78;
            urun4.UrunBedeni = "Xlarge";

            Icerik urun5 = new Urun();
            urun5.UrunAdi = "Bikini Altı";
            urun5.UrunFiyati = 67;
            urun5.UrunBedeni = "Medium"

            Icerik[] urunler = new Icerik[] { urun1, urun2, urun3, urun4, urun5 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunBedeni + " " + urun.UrunAdi + " " + urun.UrunFiyati + "TL")
            }

            Console.WriteLine("Hello World!");
        }
    }
}






class Icerik
{
    public string UrunAdi { get; set; }
    public string UrunBedeni { get; set; }
    public int UrunFiyati { get; set; }

}
