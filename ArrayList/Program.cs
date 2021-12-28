// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

//System.Collections namespace

ArrayList liste = new ArrayList();
//liste.Add("Ayşe");
liste.Add(2);
//liste.Add(true);
//liste.Add('A');

// Verilere Erişme

//Console.WriteLine(liste[1]);

/*foreach(var item in liste){
    Console.WriteLine(item);
}*/

// Add Range

Console.WriteLine("****** ADD RANGE *******");
//string[] renkler = {"kırmızı","sarı","yeşil"};
List<int> sayılar = new List<int>(){1,8,3,5,6,9};

//liste.AddRange(renkler);
liste.AddRange(sayılar);

foreach(var item in liste){
    Console.WriteLine(item);
}

//Sort

Console.WriteLine("********* SORT ********");
liste.Sort();

//Binary Search

Console.WriteLine("***** Binary Search *****");
Console.WriteLine(liste.BinarySearch(9));

//Reverse

Console.WriteLine("******REVERSE*******");
liste.Reverse();
foreach(var item in liste){
    Console.WriteLine(item);
}

//Clear
Console.WriteLine("****** CLEAR *****");
liste.Clear();
foreach(var item in liste){
    Console.WriteLine(item);
}
