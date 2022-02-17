using System;
using System.Collections;

ArrayList liste = new ArrayList();
liste.Add("Volkan");
liste.Add(10);
liste.Add(true);
liste.Add('N');


Console.WriteLine(liste[0]);
foreach (var item in liste)
{
    Console.WriteLine(item);
}

Console.WriteLine("**********");
string[] renkler = { "Yeşil", "Beyaz", "Mavi", "Kırmızı" };
List<int> sayilar = new List<int>() { 1, 2, 56, 4, 66, 8 };
liste.AddRange(renkler);
liste.AddRange(sayilar);
foreach (var item in liste)
{
    Console.WriteLine(item);
}
//liste.Sort(); //Bütün elemanların aynı değişken türünde olması gerekir.
//liste.BinarySearch(3); //Sort işleminden sonra kullanılır.
//liste.Reverse(); // Listeyi ters sıralar
//liste.Clear(); // Bütün listeyi siler.