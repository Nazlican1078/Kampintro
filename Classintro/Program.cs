using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //değişken
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68 ;

            //değişken
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA";
            kurs2.Egitmen = "Kerem  Varış";
            kurs2.IzlenmeOrani = 64;

            //değişken
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " :" + kurs1.Egitmen);

            //dizide kendi tanımladığımız class tipinde tutabilmek adına...
            Kurs[] kurslar = new Kurs[]
                {
                kurs1,
                kurs2,
                kurs3
                };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" :"+ kurs.Egitmen);
            }

            
        }
    }

    class Kurs
    {
        //kursun özellikleri
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
