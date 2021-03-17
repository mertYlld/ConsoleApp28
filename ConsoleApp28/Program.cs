using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.urunAdi = "İphone 5";
            urun1.fiyati = 700;
            urun1.bellek = "16 GB";
            urun1.renk = "Beyaz, Siyah, Gold";

            Product urun2 = new Product();
            urun2.urunAdi = "İphone 6";
            urun2.fiyati = 2875;
            urun2.bellek = "16 GB / 32 GB / 64 GB";
            urun2.renk = "Beyaz, Siyah, Gold, Gri";

            Product urun3 = new Product();
            urun3.urunAdi = "İphone 6s";
            urun3.fiyati = 3099;
            urun3.bellek = "32 GB / 64 GB";
            urun3.renk = "Beyaz, Siyah, Uzay Grisi, Rose Gold";

            Product urun4 = new Product();
            urun4.urunAdi = "İphone 7";
            urun4.fiyati = 4409;
            urun4.bellek = "32 GB / 64 GB / 128 GB / 256 GB";
            urun4.renk = "Beyaz, Siyah, Simsiyah, Gümüş, Rose Gold, Kırmızı, Pembe";

            Product urun5 = new Product();
            urun5.urunAdi = "İphone 7s";
            urun5.fiyati = 5999;
            urun5.bellek = "32 GB / 64 GB / 128 GB";
            urun5.renk = "Beyaz, Siyah, Simsiyah, Gümüş, Rose Gold, Kırmızı, Pembe";

            Product urun6 = new Product();
            urun6.urunAdi = "İphone 8";
            urun6.fiyati = 6899;
            urun6.bellek = "64 GB / 128 GB / 256 GB";
            urun6.renk = "Beyaz, Siyah, Gümüş, Gold, Uzay Grisi";

            Product urun7 = new Product();
            urun7.urunAdi = "İphone 8 Plus";
            urun7.fiyati = 7300;
            urun7.bellek="64 GB / 128 GB / 256 GB";
            urun7.renk= "Beyaz, Siyah, Gümüş, Gold, Uzay Grisi";

            Product urun8 = new Product();
            urun8.urunAdi = "İphone X";
            urun8.fiyati = 9999;
            urun8.bellek = "128 GB / 256 GB";
            urun8.renk = "Beyaz, Siyah, Gümüş, Uzay Grisi";

            Product urun9 = new Product();
            urun9.urunAdi = "İphone 11";
            urun9.fiyati = 7599;
            urun9.bellek = "64 GB / 128 GB / 256 GB";
            urun9.renk = "Beyaz, Siyah, Kırmızı, Mor, Sarı, Yeşil";

            Product urunA = new Product();
            urunA.urunAdi = "İphone 11 Pro";
            urunA.fiyati = 11999;
            urunA.bellek = "64 GB / 128 GB / 256 GB";
            urunA.renk = "Beyaz, Siyah, Gece Yeşili, Gümüş, Uzay Grisi";

            Product urunB = new Product();
            urunB.urunAdi = "İphone 11 Pro Max";
            urunB.fiyati = 12799;
            urunB.bellek = "64 GB / 256 GB / 512 GB";
            urunB.renk = "Beyaz, Siyah, Gece Yeşili, Gümüş, Uzay Grisi";

            Product[] urunler = new Product[] { urun1, urun2, urun3, urun4, urun5, urun6, urun7, urun8, urun9, urunA, urunB };
            foreach (Product urun in urunler) 
            {
                Console.WriteLine(urun.urunAdi + ": " + urun.fiyati + " Bellek: " + urun.bellek + " Renk: " + urun.renk);
            }
            Console.WriteLine(" ");

            SepeteEkle sepeteEkle = new SepeteEkle();
            {
                sepeteEkle.Ekle(urun1);
                sepeteEkle.Ekle(urun2);
                sepeteEkle.Ekle(urun3);
                sepeteEkle.Ekle(urun4);
                sepeteEkle.Ekle(urun5);
                sepeteEkle.Ekle(urun6);
                sepeteEkle.Ekle(urun7);
                sepeteEkle.Ekle(urun8);
                sepeteEkle.Ekle(urun9);
                sepeteEkle.Ekle(urunA);
                sepeteEkle.Ekle(urunB);
            }


        }
    }
}
