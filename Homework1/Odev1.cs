using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Odev1
    {
        public void odev1()
        {
            //1. Algoritma Sorusu

            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int[] sayilar = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(i + 1 + ". Sayıyı giriniz");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in sayilar)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }
        }
        public void odev2()
        {
            Console.Write("Lütfen pozitif bir 1. sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen pozitif bir 2. sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[sayi1];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(i + 1 + ". Sayıyı giriniz");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in sayilar)
            {
                if (item == sayi2 || item % sayi2 == 0)
                {
                    Console.Write(item + " ");
                }
            }
        }
        public void odev3()
        {
            Console.Write("Lütfen pozitif bir sayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            string[] kelimeler = new string[sayi1];
            for (int i = 0; i < kelimeler.Length; i++)
            {
                Console.WriteLine(i + 1 + ". Kelimeyi giriniz");
                kelimeler[i] = Console.ReadLine();
            }
            for (int i = kelimeler.Length - 1; i >= 0; i--)
            {
                Console.Write(kelimeler[i] + " ");
            }
        }
        public void odev4()
        {
            int sayac = 1;
            Console.Write("Cümle giriniz: ");
            string cumle = Console.ReadLine().Trim();
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle.Substring(i,1)==" ")
                {
                    sayac += 1;
                }
            }
            Console.WriteLine("Bu metinde {0} kelime kullanılmıştır.", sayac);
            Console.WriteLine("Bu metinde {0} harf kullanılmıştır.", cumle.Length-(sayac-1));
        }
    }
}
