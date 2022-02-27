using System;
using System.Collections;
namespace HomeWork2Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cümle girişi yapınız: ");
            string cumle = Console.ReadLine();
            char[] sesli = { 'a', 'e', 'o', 'ö', 'u', 'ü', 'ı', 'i', 'A', 'E', 'O', 'Ö', 'U', 'Ü', 'I', 'İ' };
            char[] cumleHarfleri = cumle.ToCharArray();
            ArrayList gecenSesliHarf = new ArrayList();
            for (int i = 0; i < cumleHarfleri.Length; i++)
            {
                foreach (var item in sesli)
                {
                    if (item == cumleHarfleri[i])
                    {
                        gecenSesliHarf.Add(item);
                    }
                }
            }
            foreach (var item in gecenSesliHarf)
            {
                Console.Write(item + " ");
            }
        }
    }
}
