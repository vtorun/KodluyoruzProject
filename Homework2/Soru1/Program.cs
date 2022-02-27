using System;
using System.Collections;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 Adet Sayı Giriniz...");
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            int sayi;
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i + ". Sayıyı Giriniz: ");
                sayi = int.Parse(Console.ReadLine());
                if (AsalMı(sayi))
                {
                    asalSayilar.Add(sayi);
                }
                else
                {
                    asalOlmayanSayilar.Add(sayi);
                }
            }
            Console.WriteLine("-----------");

            asalSayilar.Sort();
            asalSayilar.Reverse();
            asalOlmayanSayilar.Sort();
            asalOlmayanSayilar.Reverse();
            Console.WriteLine("------Asal Sayılar------");
            foreach (var item in asalSayilar)
                Console.WriteLine(item);

            Console.WriteLine("------Asal Olmayan Sayılar------");
            foreach (var item in asalOlmayanSayilar)
                Console.WriteLine(item);
            Console.WriteLine("Asal Sayıların Ortalaması=  " + DiziOrtalamasi(asalSayilar) + "  Dizideki Eleman Sayısı= " + DiziElamanSayisi(asalSayilar));
            Console.WriteLine("Asal Sayıların Ortalaması=  " + DiziOrtalamasi(asalOlmayanSayilar) + "  Dizideki Eleman Sayısı= " + DiziElamanSayisi(asalOlmayanSayilar));
        }
        static bool AsalMı(int sayi)
        {
            int sayac = 0;
            for (int j = 1; j <= sayi; j++)
            {
                if (sayi % j == 0)
                {
                    sayac++;
                }
            }
            if (sayac > 2)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        static int DiziElamanSayisi(ArrayList arrayList)
        {
            return arrayList.Count;
        }
        static double DiziOrtalamasi(ArrayList arrayList)
        {
            double sonuc = 0;
            foreach (var item in arrayList)
            {
                sonuc += Convert.ToDouble(item);
            }
            return sonuc / Convert.ToDouble(DiziElamanSayisi(arrayList));
        }

    }
}

