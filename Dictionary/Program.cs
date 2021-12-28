// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

kullanicilar.Add(10,"Ayşe Yılmaz");
kullanicilar.Add(12,"Ahmet Yılmaz");
kullanicilar.Add(18,"Deniz Arda");
kullanicilar.Add(20,"Özcan Coşar");
//Aynısından bir tane daha eklenmiyor
//Dizinin elemanlarına erişim

Console.WriteLine("*******Elemanlara Erişme*******");
Console.WriteLine(kullanicilar[12]);

foreach(var item in kullanicilar){
    Console.WriteLine(item);
}

// Count

Console.WriteLine(kullanicilar.Count);

// Contains
Console.WriteLine("*******Contains*******");
Console.WriteLine(kullanicilar.ContainsKey(12));
Console.WriteLine(kullanicilar.ContainsValue("Alp Eren"));

//Remove

Console.WriteLine("*******Remove*******");
kullanicilar.Remove(12);

foreach(var item in kullanicilar){
    Console.WriteLine(item.Value); //item.Key
}

//Keys
Console.WriteLine("*******Keys*******");
foreach(var item in kullanicilar.Keys){
    Console.WriteLine(item); 
}
//Values
Console.WriteLine("*******Values*******");

foreach(var item in kullanicilar.Values){
    Console.WriteLine(item);
}