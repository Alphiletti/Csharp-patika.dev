// See https://aka.ms/new-console-template for more information


string degisken = "Dersimiz C# Hoşgeldiniz!!";
string degisken2 = "C# Hoşgeldiniz!!";

//length
Console.WriteLine(degisken.Length);

//toUpper and toLower

Console.WriteLine(degisken.ToLower());
Console.WriteLine(degisken.ToUpper());

//concat

Console.WriteLine(String.Concat(degisken,"Merhaba"));

//Compare, compare to

Console.WriteLine(degisken.CompareTo(degisken2));
Console.WriteLine(String.Compare(degisken,degisken2,true));
Console.WriteLine(String.Compare(degisken,degisken2,false));

//Contains
Console.WriteLine(degisken.Contains(degisken2));

Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!!"));
Console.WriteLine(degisken.StartsWith("Merhaba"));

//IndexOf
Console.WriteLine(degisken.IndexOf("C#"));
Console.WriteLine(degisken.IndexOf("Alp"));
Console.WriteLine(degisken.LastIndexOf("i"));

//Insert
Console.WriteLine(degisken.Insert(0,"Merhaba! "));

//PadLeft, PadRight

Console.WriteLine(degisken + degisken2.PadLeft(30));
Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
Console.WriteLine(degisken.PadRight(50) + degisken2);
Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

//Remove

Console.WriteLine(degisken.Remove(10)); //10. indexten öncekileri getiriyor
Console.WriteLine(degisken.Remove(5,3));
Console.WriteLine(degisken.Remove(0,1));

//Replace
Console.WriteLine(degisken.Replace("C#","CSharp"));
Console.WriteLine(degisken.Replace(" ","*"));

//Split

Console.WriteLine(degisken.Split(' ')[2]);

//Substring

Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4,6));


Console.ReadLine();
