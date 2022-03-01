﻿Calisan calisan1 = new Calisan("Volkan", "Torun", 112233, "Yazılım Geliştirme");
calisan1.CalisanBilgiler();

Calisan calisan2 = new Calisan("Nurcan", "Torun", 112233, "İnsan Kaynakları");
calisan2.CalisanBilgiler();

Calisan calisan3 = new Calisan("Abcd", "aasdds");
calisan3.CalisanBilgiler();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }

    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }

    public Calisan()
    {

    }
    public void CalisanBilgiler()
    {
        Console.WriteLine("Çalışan Adı: {0}", Ad);
        Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışan Numarası: {0}", No);
        Console.WriteLine("Çalışan Departmanı: {0}", Departman);
    }
}