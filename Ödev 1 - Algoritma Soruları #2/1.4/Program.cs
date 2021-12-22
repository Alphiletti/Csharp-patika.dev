// See https://aka.ms/new-console-template for more information
/*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/

string cumle;
Console.WriteLine("Lütfen aşağıya bir cümle yazınız; ");
cumle = Console.ReadLine();

int kelime_counter = 1, harf_counter = 0,bosluk_counter = 0;

for(int i=0; i < cumle.Length; i++){
    if(cumle.ElementAt(i) == ' '){
        bosluk_counter++;
        kelime_counter++;
    }
    else{
        harf_counter += 1;
    }
}
Console.WriteLine($"Cümledeki harf sayısı: {harf_counter}");
Console.WriteLine($"Cümledeki kelime sayısı: {kelime_counter}");


Console.ReadLine();

    

