// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Dikdortgen dikdortgen = new Dikdortgen();

dikdortgen.KisaKenar = 3;
dikdortgen.UzunKenar = 4;

Console.WriteLine("Class Alan Hesabı = {0}",dikdortgen.AlanHesapla());

Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct();
dikdortgen_struct.KisaKenar = 3;
dikdortgen_struct.UzunKenar = 4;

Console.WriteLine("Struct Alan Hesabı = {0}",dikdortgen_struct.AlanHesapla());

Console.ReadKey(true);



class Dikdortgen{
    public int KisaKenar;
    public int UzunKenar;

    public long AlanHesapla(){
        return this.KisaKenar * this.UzunKenar;
    }
}

struct Dikdortgen_Struct{
    public int KisaKenar;
    public int UzunKenar;

    public long AlanHesapla(){
        return this.KisaKenar * this.UzunKenar;
    }
}