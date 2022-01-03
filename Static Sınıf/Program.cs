// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

Calisan calisan = new Calisan("Alp","Eren","İK");
Calisan calisan1 = new Calisan("Ahmet","Emre","Muhasebe");
Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(5,6));
Console.WriteLine("Çıkarma işlemi sonucu: {0}", Islemler.Cikar(15,6));

//Static sınıflara kalıtım uygulanmıyor.


Console.ReadLine();


class Calisan{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi;}

    private string Isim;
    private string Soyisim;

    private string Departman;

    static Calisan(){
        calisanSayisi = 0;
    }
    
    public Calisan(string ısim, string soyisim, string departman)
    {
        Isim = ısim;
        Soyisim = soyisim;
        Departman = departman;
        calisanSayisi++;
    }
}

static class Islemler{
        public static long Topla(int sayi1, int sayi2){
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2){
            return sayi1 - sayi2;
        }
    }

