using System;

namespace Calisma1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");

            }
            Console.WriteLine(kategoriEtiketi);

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            string[] kurslar = new string[] { kurs1, "Programlamaya Başlangıç İçin Temel Kurs", 
                "Java", "Python", "C++" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu-footer");

            Urun urun1 = new Urun();
            urun1.UrunAdi = "Pantolon";
            urun1.UrunFiyati = 25;
            urun1.UrunRenk = "Beyaz";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Şort";
            urun2.UrunFiyati = 75;
            urun2.UrunRenk = "Siyah";

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Gömlek";
            urun3.UrunFiyati = 120;
            urun3.UrunRenk = "Lacivert";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.UrunFiyati + " : " + urun.UrunRenk);
            }

            string kullanici1 = "Ahmet";
            string kullanici2 = "Mehmet";
            string kullanici3 = "Ömer";
            string kullanici4 = "Ayşe";
            string kullanici5 = "Feridun";

            Console.WriteLine(kullanici1);
            Console.WriteLine(kullanici2);
            Console.WriteLine(kullanici3);
            Console.WriteLine(kullanici4);
            Console.WriteLine(kullanici5);

            string[] Kullanicilar = new string[] { kullanici1, kullanici2, kullanici3, 
                kullanici4,kullanici5 };

            for (int i = 0; i < Kullanicilar.Length; i++)
            {
                Console.WriteLine(Kullanicilar[i]);
            }

            double sayi1 = 3.0;
            double sayi2 = 4.0;
            Console.WriteLine((sayi1 + sayi2)/2);

            string semt1 = "Kadıköy";
            string semt2 = "Beşiktaş";
            string semt3 = "Beyoğlu";
            string semt4 = "Üsküdar";
            string semt5 = "Sarıyer";

            Console.WriteLine(semt1);
            Console.WriteLine(semt2);
            Console.WriteLine(semt3);
            Console.WriteLine(semt4);
            Console.WriteLine(semt5);

            string[] semtler = new string[] {semt1, semt2, semt3, semt4, semt5 };
            
            for (int i = 0; i < semtler.Length; i++)
            {
                Console.WriteLine(semtler[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string semt in semtler)
            {
                Console.WriteLine(semt);
            }

            string meyve1 = "Elma";
            double fiyat1 = 10;
            string aciklama1 = "Kırmızı elma";

            

           string meyve2 = "Ayva";
            double fiyat2 = 5;
            string aciklama2 = "Taze ayva";

            string[] meyveler = new string[] { meyve1, meyve2 };

            foreach (var meyve in meyveler)
            {
                Console.WriteLine(meyve);
            }

            for (int i = 0; i < meyveler.Length; i++)
            {
                Console.WriteLine(meyveler[i]);
            }
            
            Console.WriteLine("Tebrikler. Sepete eklendi:" + meyve1);
            Console.WriteLine("Tebrikler. Sepete eklendi:" + meyve2);

            string sehir1 = "İstanbul";
            int nufus1 = 15000;
            string Bolge1 = "Marmara";
            
            string sehir2 = "Bursa";
            int nufus2 = 10000;
            string Bolge3 = "Marmara";
            
            string sehir3 = "Antalya";
            int nufus3 = 5000;
            string bolge3 = "Akdeniz";

            string[] Sehir = new string[] {sehir1, sehir2,sehir3 };

            Console.WriteLine("İstanbul'un nüfusu:" + nufus1);
            Console.WriteLine("Bursa'nın nüfusu:" + nufus2);
            Console.WriteLine("Antalya'nın nüfusu:" + nufus3);


        











        }
    }
}
