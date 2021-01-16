using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            // do not repeat your self- kendinş tekrarlama...!
            //değer tutucu, alias


            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizorani = 1.45;
            bool sistemeGrisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");

            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            if (sistemeGrisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            Console.ReadKey();
        }
    }
}
