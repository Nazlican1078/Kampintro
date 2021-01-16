using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle (Urun urun)//parametreli method
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi );
        }
        public void Ekle2(string urunAdi, string Aciklama, double Fiyat, int stokadedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
