using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28
{
    class SepeteEkle
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.urunAdi, urun.fiyati, urun.bellek, urun.renk);
        }
    }
}
