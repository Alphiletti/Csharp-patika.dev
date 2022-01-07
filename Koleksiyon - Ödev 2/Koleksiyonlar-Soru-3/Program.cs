/*
 * Created by SharpDevelop.
 * User: Alp
 * Date: 1/7/2022
 * Time: 10:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			string cumle = "";
			
			Console.WriteLine("Lütfen bir cümle giriniz: ");
			cumle = Console.ReadLine();
			
			HashSet<char> Holder = new HashSet<char>();
			
//			Console.WriteLine(cumle);
//			cumle.ToLower();
//			Console.WriteLine(cumle.ToLower());
			
			foreach (char e in cumle.ToLower()) {
				if (e == 'a' || e == 'e' || e == 'i' || e == 'o' || e == 'ö' || e == 'u' || e == 'ü' || e == 'I' || e == 'ı') {
					Holder.Add(e);
					//Compiler yüzünden büyük ihtimalle büyük I girince toLower fonksiyonu i olarak küçültüyor. Some Turkish Language Problems..
				}

			}
			
			Console.WriteLine("-------------");
			Console.Write("Cümledeki Sesli Harfler: ");
			foreach (var element in Holder) {
				Console.Write(element);
			}
			
			
			Console.ReadKey(true);
		}
	}
}