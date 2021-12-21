// See https://aka.ms/new-console-template for more information
string sayi ="999";
bool sonuc = int.TryParse(sayi, out int outSayi);
if(sonuc){
    Console.WriteLine("Başarılı.");
    Console.WriteLine(outSayi);
    
}
else{
    Console.WriteLine("Başarısız..");
    
}

Metotlar M1 = new Metotlar();
M1.Topla(5,7,out int toplamSonuc);
Console.WriteLine(toplamSonuc);


// Overloading

int ifade = 999;
M1.EkranaYazdir(Convert.ToString(ifade));
M1.EkranaYazdir(ifade);
M1.EkranaYazdir("Alp","Eren");
Console.ReadLine();

// Metot İmzası
// MetotAdı + parametre sayısı + parametre
class Metotlar{
    public void Topla(int a, int b,out int toplam){
        toplam = a + b;
    }

    public void EkranaYazdir(string veri){
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri){
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1, string veri2){
        Console.WriteLine(veri1 + veri2);
    }
}