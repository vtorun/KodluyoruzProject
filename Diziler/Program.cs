using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bitkiler = new string[9];
            string[] hayvanlar = { "Kedi", "Balık", "Timsah", "Karınca", "Yılan", "Tavuk" };
            int[] dizi;
            dizi = new int[4];
            bitkiler[0] = "Ağaç";
            dizi[3] = 11;

            Console.WriteLine(hayvanlar[3]);
            Console.WriteLine(bitkiler[0]);
            Console.WriteLine(dizi[3]);

            Console.Write("Eleman sayısı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int[] sayilar = new int[n];
            int toplam = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());

            }
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            Console.WriteLine(toplam / n);

        }
    }
}
