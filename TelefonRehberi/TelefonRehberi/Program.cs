using System;
using System.Collections.Generic;

namespace TelefonRehberi
{
    class Program
    {
        static List<Person> rehber = new List<Person>();
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            rehber.Add(new Person(1, "Volkan", "Torun", "5555555555"));
            rehber.Add(new Person(2, "Nurcan", "Torun", "4444444444"));
            rehber.Add(new Person(3, "Aydın", "Efe", "3333333333"));
            rehber.Add(new Person(4, "Nazlı", "Çelik", "2222222222"));
            rehber.Add(new Person(5, "Ahmet", "Sakar", "9999999999"));

            IslemSecme islemSecme = new IslemSecme();
        test:
            islemSecme.YapilacakIslem(rehber);
            int islem = int.Parse(Console.ReadLine());
            switch (islem)
            {
                case 1:
                    personManager.Add(rehber);
                    goto test;
                case 2:
                    personManager.Delete(rehber);
                    goto test;
                case 3:
                    personManager.Update(rehber);
                    goto test;
                case 4:
                    personManager.ListAll(rehber);
                    goto test;
                case 5:
                    personManager.ListPerson(rehber);
                    goto test;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("******Uygun Seçim Yapmadınız******");
                    goto test;
            }
        }
    }
}

