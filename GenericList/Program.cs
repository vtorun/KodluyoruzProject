List<int> sayilar = new List<int>();
sayilar.Add(1);
sayilar.Add(2);
sayilar.Add(3);
sayilar.Add(4);
sayilar.Add(5);
sayilar.Add(6);
sayilar.Add(16);

List<string> renkler = new List<string>();
renkler.Add("Mavi");
renkler.Add("Sarı");
renkler.Add("Yeşil");
renkler.Add("Kırmızı");
renkler.Add("Turuncu");

Console.WriteLine(sayilar.Count);
Console.WriteLine(renkler.Count);

foreach (var item in sayilar)
{
    Console.WriteLine(item);
}
foreach (var item in renkler)
{
    Console.WriteLine(item);
}

sayilar.ForEach(sayi => Console.WriteLine(sayi));
renkler.ForEach(renk => Console.WriteLine(renk));


sayilar.Remove(1);
renkler.Remove("Mavi");

sayilar.RemoveAt(0);
renkler.RemoveAt(0);


sayilar.ForEach(sayi => Console.WriteLine(sayi));
renkler.ForEach(renk => Console.WriteLine(renk));


if (sayilar.Contains(3))
    Console.WriteLine("Listede vardır.");

Console.WriteLine(renkler.BinarySearch("Turuncu"));

string[] hayvanlar = { "Kedi", "Kuş", "Fil", "Maymun" };
List<string> hayvanList = new List<string>(hayvanlar);

hayvanList.Clear();

List<Kullanicilar> kullanicilars = new List<Kullanicilar>();
Kullanicilar k1 = new Kullanicilar();

k1.Isim = "Volkan";
k1.Soyad = "Torun";
k1.Yas = 32;

Kullanicilar k2 = new Kullanicilar();

k2.Isim = "Nurcan";
k2.Soyad = "Torun";
k2.Yas = 30;

kullanicilars.Add(k1);
kullanicilars.Add(k2);


List<Kullanicilar> yeniListe = new List<Kullanicilar>();

yeniListe.Add(new Kullanicilar()
{
    Isim = "Enes",
    Soyad = "Aras",
    Yas = 10

});

foreach (var item in kullanicilars)
{
    Console.WriteLine(item.Isim);
    Console.WriteLine(item.Soyad);
    Console.WriteLine(item.Yas);
}
foreach (var item in yeniListe)
{
    Console.WriteLine(item.Isim);
    Console.WriteLine(item.Soyad);
    Console.WriteLine(item.Yas);
}
               


    public class Kullanicilar
{
    private string isim;
    private string soyad;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyad { get => soyad; set => soyad = value; }
    public int Yas { get => yas; set => yas = value; }
}