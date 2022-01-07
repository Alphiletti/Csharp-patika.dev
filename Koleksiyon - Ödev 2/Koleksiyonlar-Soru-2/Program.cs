/*
 * Created by SharpDevelop.
 * User: Alp
 * Date: 1/7/2022
 * Time: 9:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Koleksiyonlar_Soru_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] sayilar = new int[20];
			
			for (int i = 0; i < 20; i++) {
				sayilar[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("-------------------");
			
			for (int j = 0; j < 20; j++) {
				for (int i = 0; i < 19; i++) {
					if (sayilar[i] > sayilar[i + 1]) {
						int temp = sayilar[i];
						sayilar[i] = sayilar[i + 1];
						sayilar[i + 1] = temp;
					}
				}
			}
			
			
			Console.WriteLine("En Büyük Üç Eleman: {0} {1} {2}",sayilar[19],sayilar[18],sayilar[17]);
			Console.WriteLine("En Küçük Üç Eleman: {0} {1} {2}",sayilar[0],sayilar[1],sayilar[2]);
			
			double max = sayilar[19] + sayilar[18] + sayilar[17];
			double min = sayilar[0] + sayilar[1] + sayilar[2];
			Console.WriteLine("En Büyük Üç Elemanın Ortalaması: {0}",max/3);
			Console.WriteLine("En Küçük Üç Elemanın Ortalaması: {0}",min/3);
			
			double toplam = (max/3) + (min/3);
			
			Console.WriteLine("Ortalama Toplamları: {0}",toplam);
			Console.ReadKey(true);
		}
	}
}