/*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/

int n = 0;
Console.Write("Lütfen kaç tane kelime girmek istediğinizi girin: ");
n = Convert.ToInt32(Console.ReadLine());
if(n < 0){
    Console.WriteLine("Lütfen pozitif bir sayı girin.");
}
else {
    string[] kelimeDizisi = new string[n];
    for(int i = 0; i < n; i++){
        Console.WriteLine("{0}.Kelimeyi giriniz: ",i+1);
        kelimeDizisi[i] = Console.ReadLine();
    }
    
    int counter = kelimeDizisi.Length - 1;
    for(int i = 0; i < kelimeDizisi.Length; i++){
        Console.WriteLine(kelimeDizisi[counter]);
        counter -= 1;
    }

    Console.ReadLine();

    
}

