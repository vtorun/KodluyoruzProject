Calisan calisan1 = new Calisan();
calisan1.Ad = "Volkan";
calisan1.Soyad = "Torun";
calisan1.No = 112233;
calisan1.Departman = "Yazılım Geliştirme";
calisan1.CalisanBilgiler();

Console.WriteLine("----------------");

Calisan calisan2 = new Calisan();
calisan2.Ad = "Nurcan";
calisan2.Soyad = "Torun";
calisan2.No = 112233;
calisan2.Departman = "İnsan Kaynakları";

calisan2.CalisanBilgiler();
  

    class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgiler()
    {
        Console.WriteLine("Çalışan Adı: {0}", Ad);
        Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışan Numarası: {0}", No);
        Console.WriteLine("Çalışan Departmanı: {0}", Departman);
    }
}
