﻿using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "engin demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem varış";
            kurs2.IzlenmeOrani = 64;
            //Kurs onurunKursu = new Kurs { KursAdi = "deneme", Egitmen = "deneme", IzlenmeOrani = 1 };
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;



            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };



            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Console.WriteLine("Hello World!");
        }
    }
}
class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }

}
