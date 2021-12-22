/* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/

int n = 0;
Console.Write("Lütfen kaç tane sayı girmek istediğinizi girin: ");
n = Convert.ToInt32(Console.ReadLine());
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
    if(sayiDizisi[i] % 2 == 0){
        Console.Write(sayiDizisi[i] + " ");
    }
}
}

Console.ReadLine();
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




