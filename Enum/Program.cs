/*
 * Created by SharpDevelop.
 * User: Alp
 * Date: 1/3/2022
 * Time: 9:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Enum
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(Gunler.Pazar);
			Console.WriteLine((int)Gunler.Cumartesi);
			
			int sicaklik = 32;
			
			if(sicaklik <= (int)havaDurumu.Normal){
				Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekle.");
			}
			else if(sicaklik >= (int)havaDurumu.Sıcak){
				Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
			}
			else if(sicaklik >= (int)havaDurumu.Normal && sicaklik < (int)havaDurumu.CokSıcak){
				Console.WriteLine("Hadi dışarıya çıkalım");
			}
			
			Console.ReadKey(true);
		}
		
		enum Gunler{
			Pazartesi,
			Salı,
			Çarşamba,
			Perşembe,
			Cuma,
			Cumartesi,
			Pazar
		}
		
		enum havaDurumu{
			Soguk = 5,
			Normal = 20,
			Sıcak = 25,
			CokSıcak = 30,
		}
	}
}