using System;
using System.Collections;

namespace HomeWork2Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 Adet Sayı Giriniz...");
            ArrayList arrayList = new ArrayList();
            int sayi;
            for (int i = 1; i <= 6; i++)
            {
                Console.Write(i + ". Sayıyı Giriniz: ");
                sayi = int.Parse(Console.ReadLine());
                arrayList.Add(sayi);
            }
            arrayList.Sort();
            Console.WriteLine("-------En Küçük Sayılar-------");
            double kucukSayilarToplami = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arrayList[i]);
                kucukSayilarToplami += Convert.ToDouble(arrayList[i]);
            }
            Console.WriteLine("-------En Büyük Sayılar-------");
            double buyukSayilarToplami = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arrayList[arrayList.Count - i - 1]);
                buyukSayilarToplami +=Convert.ToDouble(arrayList[arrayList.Count - i - 1]);
            }
            Console.WriteLine("-------Küçük Sayıların Ortalaması-------");
            Console.WriteLine(Convert.ToDouble(kucukSayilarToplami / 3));
            Console.WriteLine("-------Büyük Sayıların Ortalaması-------");
            Console.WriteLine(Convert.ToDouble(buyukSayilarToplami / 3));
        }
    }
}
