/*
 * Created by SharpDevelop.
 * User: Alp
 * Date: 12/30/2021
 * Time: 9:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Lütfen 20 tane sayı giriniz");
			ArrayList prime_array = new ArrayList();
			ArrayList nonprime_array = new ArrayList();
			
			
			for (int i = 0; i < 20; i++) {
				int number = Convert.ToInt32(Console.ReadLine());
				if (number < 0){
					Console.WriteLine("Lütfen pozitif bir tam sayı giriniz.");
				}
				else{
					if(IsPrime(number)){
						prime_array.Add(number);
					}
					else{
						nonprime_array.Add(number);
					}
				}
				
			}
			
			prime_array.Sort();
			prime_array.Reverse();
			nonprime_array.Sort();
			nonprime_array.Reverse();
			
			Console.WriteLine("------ Non-Prime Numbers ------");
			double nonToplam = 0;
			foreach (int element in nonprime_array) {
				Console.WriteLine(element);
				nonToplam += element;
				
			}
			Console.WriteLine("Asal olmayan dizideki eleman sayısı: {0}", nonprime_array.Count);
			Console.WriteLine("Asal Olmayan Sayı Ortalama: {0}", (nonToplam/nonprime_array.Count));
			
			Console.WriteLine("------ Prime Numbers ------");
			double toplam = 0;
			foreach (int item in prime_array) {
				Console.WriteLine(item);
				toplam += item;
			}
			Console.WriteLine("Asal olan dizideki eleman sayısı: {0}", prime_array.Count);
			Console.WriteLine("Asal Sayı Ortalama: {0}", (toplam/prime_array.Count));
			
			
			Console.ReadLine();
		}
		
		public static bool IsPrime(int number){
			bool result = true;
			
			if(number == 1 || number == 0){
				return false;
			}
			
			for (int i = 2; i < number; i++){
				if (number % i == 0){
					result = false;
					break;
				}
			}
			
			return result;
		}
	}
	
	
}