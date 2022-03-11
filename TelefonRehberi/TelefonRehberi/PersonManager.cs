using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    class PersonManager : IPersonService
    {
        IslemSecme islemSecme = new IslemSecme();
        Personİslemler personIslemler = new Personİslemler();
        public void Add(List<Person> rehber)
        {
            Person person = new Person();
            Console.Write("Adı: ");
            person.FirstName = Console.ReadLine();
            Console.Write("Soyadı: ");
            person.LastName = Console.ReadLine();
            Console.Write("Telefon Numarası: ");
            person.Phone = Console.ReadLine();
            person.Id = rehber.Count + 1;
            rehber.Add(person);
            Console.WriteLine(person.FirstName + " Eklendi");


        }
        public void Update(List<Person> rehber)
        {
        //Person person = new Person();
        a:
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string name = Console.ReadLine();
            int indexNo = personIslemler.personSearch(rehber, name);
            if (indexNo >= 0)
            {
                Console.Write("Yeni Telefon Numarası: ");
                rehber[indexNo].Phone = Console.ReadLine();
                Console.WriteLine(rehber[indexNo].FirstName + " Güncellendi");
            }
            else
            {
                islemSecme.UpdateNotFoundPerson();
                int secim = Int32.Parse(Console.ReadLine());
                if (secim == 1)
                {

                }
                else
                {
                    goto a;
                }
            }



        }
        public void Delete(List<Person> rehber)
        {
            int deletedIndex;
        a:
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string name = Console.ReadLine();
            deletedIndex = personIslemler.personSearch(rehber, name);
            if (deletedIndex != -1)
            {
                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", name);
                string control = Console.ReadLine();
                if (control.ToLower() == "y")
                {
                    rehber.RemoveAt(deletedIndex);
                }
                else if (control.ToLower() == "h")
                {
                    Console.WriteLine("Silme İşlemi İptal Edildi...");
                }

            }
            else
            {
                if (islemSecme.NotFoundPerson() == 1)
                {
                    //islemSecme.YapilacakIslem(rehber);
                }
                else if (islemSecme.NotFoundPerson() == 2)
                {
                    goto a;
                }
            }


        }



        public void ListAll(List<Person> rehber)
        {
            Console.WriteLine("ID" + "    " + "ADI" + "    " + "SOYADI" + "    " + "NUMARA");
            foreach (var item in rehber)
            {
                Console.WriteLine(item.Id + "    " + item.FirstName + "    " + item.LastName + "    " + item.Phone);
            }

        }

        public void ListPerson(List<Person> persons)
        {
            if (islemSecme.AramaIslemleri() == 1)
            {
                Console.WriteLine("İsim veya Soyisim Giriniz....: ");
                int personIndex = personIslemler.personSearch(persons, Console.ReadLine());
                islemSecme.AramaSonuclari(persons, personIndex);
            }
            if (islemSecme.AramaIslemleri() == 2)
            {
                Console.WriteLine("Telefon Numarası Giriniz....: ");
                int personIndex = personIslemler.personTelefonNumberSearch(persons, Console.ReadLine());
                islemSecme.AramaSonuclari(persons, personIndex);
            }
        }
    }
}
