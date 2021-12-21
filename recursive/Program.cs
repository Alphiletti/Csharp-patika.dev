// See https://aka.ms/new-console-template for more information

int Result = 1;
for(int i=1; i<5; i++){
    Result = Result * 3;
}
Console.WriteLine(Result);
Islemler i1 = new Islemler();
Console.WriteLine(i1.Expo(3,4));


//Extension metotlar

string ifade = "Alp Eren";
bool sonuc = ifade.CheckSpaces();
Console.WriteLine(sonuc);

if(sonuc){
    Console.WriteLine(ifade.RemoveSpace());
}

Console.WriteLine(ifade.UpperCase());
Console.WriteLine(ifade.LowerCase());

int[] dizi = {9,3,6,2,1,5,0};
dizi.SortArray();
dizi.EkranaYazdir();
int sayi = 5;
Console.WriteLine(sayi.IsEvenNumber());

Console.WriteLine(ifade.GetFirstChar());





Console.ReadLine();


public class Islemler{
    public int Expo(int sayi, int üs){
        
        if(üs < 2)
            return sayi;
        return Expo(sayi,üs-1)*sayi;
    }
}

public static class Extension{
        public static bool CheckSpaces(this string param){
            return param.Contains(" ");
        }

        public static string RemoveSpace(this string param){
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string UpperCase(this string param){
            return param.ToUpper();
        }

        public static string LowerCase(this string param){
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param){
            Array.Sort(param);
            return param; 
        }

        public static void EkranaYazdir(this int[] param){
            foreach(int item in param){
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param){
            return param % 2 == 0;
        }

        public static string GetFirstChar(this string param){
            return param.Substring(0,1);
        }
    }