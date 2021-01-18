using System;

namespace IfBlok
{
    class Program
    {
        static void Main(string[] args)
        {
            double class1 = 35;
            double class2 = 25;

            if (class1<class2)
            {
                Console.WriteLine("Class1 is less than class2");
            }

            else if (class1>class2)
            {
                Console.WriteLine("Class 1 is more crowded than class2");
            }

            else
            {
                Console.WriteLine("Class 1 is equal class2");
            }

            double puan1 = 67;
            double puan2 = 42;

            double toplam = puan1 + puan2;
            double bolum = puan1 / puan2;
            double ortalama = (puan1 + puan2) / 2;
            
            if (puan1<puan2)
            {
                Console.WriteLine("Toplam:" + toplam);
            }

            else if (puan1>puan2)
            {
                Console.WriteLine("Bölüm:" + bolum);
            }

            else
            {
                Console.WriteLine("Ortalama:" + ortalama);
            }



        }
    }
}
