using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class IslemSecme
    {

        public void YapilacakIslem(List<Person> rehber)
        {

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("----Yapmak İstediğiniz İşlemi Seçiniz----");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
            Console.WriteLine("(6) ÇIKIŞ");


        }
        public int NotFoundPerson()
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            return Int32.Parse(Console.ReadLine());
        }
        public int AramaIslemleri()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            return Int32.Parse(Console.ReadLine());
        }
        public void AramaSonuclari(List<Person> rehber, int indexNo)
        {
            Console.WriteLine("Arama Sonuçlarınız:");
            Console.WriteLine("**********************************************");
            Console.WriteLine("isim: " + rehber[indexNo].FirstName);
            Console.WriteLine("Soyisim: " + rehber[indexNo].LastName);
            Console.WriteLine("Telefon Numarası: " + rehber[indexNo].Phone);
        }
        public void UpdateNotFoundPerson()
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
            Console.WriteLine("* Yeniden denemek için              : (2)");
        }

    }
}
