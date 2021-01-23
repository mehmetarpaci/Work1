using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenci = new MyDictionary<int, string>();
            ogrenci.Add(1, "Ahmet");
            ogrenci.Add(2, "Elif");
            Console.WriteLine(ogrenci.Count);

            MyDictionary<int, string> ogrenci2 = new MyDictionary<int, string>();
            ogrenci.Add(1, "Mehmet");
            ogrenci.Add(2, "Salih");
            ogrenci.Add(3, "Fatih");
            Console.WriteLine(ogrenci.Count);

        }
    }
}
