using System;

namespace YazilimCampiProje1
{
    class Program
    {
        static void Main(string[] args)

        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Bluz";
            urun1.Fiyati = 35;
            urun1.Rengi = "Mor";
            urun1.Marka = "Trendyolmilla";
            urun1.Beden = 38;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Elbise";
            urun2.Fiyati = 35;
            urun2.Rengi = "Mavi";
            urun2.Marka = "LC Waikiki";
            urun2.Beden = 38;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Kazak";
            urun3.Fiyati = 100;
            urun3.Rengi = "Kırmızı";
            urun3.Marka = "Polo";
            urun3.Beden = 42;

            Urun urun4 = new Urun();
            urun4.UrunAdi = "Pantolon";
            urun4.Fiyati = 45;
            urun4.Rengi = "Beyaz";
            urun4.Marka = "Coton";
            urun4.Beden = 34;

            Urun urun5 = new Urun();
            urun5.UrunAdi = "Kaban";
            urun5.Fiyati = 200;
            urun5.Rengi = "Kahverengi";
            urun5.Marka = "Mango";
            urun5.Beden = 40;

            Console.WriteLine("*******************Foreach Döngüsü**********************");

            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4, urun5 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Beden + " : " + urun.Fiyati + " : " + urun.Marka + " : " + urun.UrunAdi + " : " + urun.Rengi);
            }


            Console.WriteLine("*******************For Döngüsü*************************");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " : " + urunler[i].Fiyati + " : " + urunler[i].Rengi + " : " + urunler[i].Marka + " : " + urunler[i].Beden);

            }


            Console.WriteLine("********************While Döngüsü************************");
            int a = 0;
            while (a < urunler.Length)
            {
                Console.WriteLine(urunler[a].UrunAdi + " : " + urunler[a].Fiyati + " : " + urunler[a].Rengi + " : " + urunler[a].Marka + " : " + urunler[a].Beden);

                a++;
            }

            Console.WriteLine("Hello World!");
        }

        class Urun
        {
            public string UrunAdi { get; set; }
            public int Fiyati { get; set; }
            public string Rengi { get; set; }
            public string Marka { get; set; }
            public int Beden { get; set; }



        }
    }
}
