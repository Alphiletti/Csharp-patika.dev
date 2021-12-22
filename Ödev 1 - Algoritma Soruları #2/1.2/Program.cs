// See https://aka.ms/new-console-template for more information
/*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın */

int n,m;
Console.Write("Lütfen kaç tane sayı girmek istediğinizi girin: ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Hangi sayıyla eşit veya tam bölünenleri bulmak istersiniz? ");
m = Convert.ToInt32(Console.ReadLine());
if(n < 0){
    Console.WriteLine("Lütfen pozitif bir sayı girin.");
}
else {
    int[] sayiDizisi = new int[n];
    for(int i = 0; i < n; i++){
        Console.WriteLine("{0}.Sayıyı giriniz: ",i+1);
        sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
    }

    for(int i = 0; i < n; i++){
        if(sayiDizisi[i] % m == 0){
        Console.Write(sayiDizisi[i] + " ");
        
        }
    }
    Console.ReadLine();
}
