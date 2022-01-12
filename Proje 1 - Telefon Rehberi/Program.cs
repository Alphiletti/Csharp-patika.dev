/*
 * Created by SharpDevelop.
 * User: Alp
 * Date: 1/9/2022
 * Time: 9:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proje_1___Telefon_Rehberi
{
	
	
	class Program
	{
		static void Menu()
		{
			Console.WriteLine("(1) Yeni Numara Kaydetmek");
			Console.WriteLine("(2) Varolan Numarayı Silmek");
			Console.WriteLine("(3) Varolan Numarayı Güncelleme");
			Console.WriteLine("(4) Rehberi Listelemek");
			Console.WriteLine("(5) Rehberde Arama Yapmak");
			Console.WriteLine("(0) Çıkış");
			Console.WriteLine("");
		}
		
		static void numarayiKaydet(Dictionary<long,string> Rehber)
		{
			Console.WriteLine("Lütfen isim giriniz\t: ");
			string name = Console.ReadLine();
			Console.WriteLine("Lütfen soyisim giriniz\t: ");
			string lName = Console.ReadLine();
			Console.WriteLine("Lütfen telefon numarası giriniz\t: ");
			long number = Convert.ToInt64(Console.ReadLine());
			Rehber.Add(number, name + " " + lName);
			Console.WriteLine("Yeni Kişi Eklendi");
		}
		
		static void numarayiSil(Dictionary<long,string> Rehber)
		{
			Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
			string adSoyad = Console.ReadLine();
			adSoyad = adSoyad.ToLower();
			//Burası daha güzel yazılabilir.
			for (int i = 0; i < Rehber.Count; i++) {
				if (Rehber.Values.ElementAt(i).ToLower().Contains(adSoyad)) {
					Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", Rehber.Values.ElementAt(i));
					string selectionYN = Console.ReadLine();
					if (selectionYN == "Y" || selectionYN == "y") {
						Rehber.Remove(Rehber.Keys.ElementAt(i));
						Console.WriteLine("Kişi bulundu ve silindi");
						break;
					}
					
				} else {
					Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
					Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
					Console.WriteLine("* Yeniden denemek için      : (2)");
					int secim = Convert.ToInt32(Console.ReadLine());
					if (secim == 2) {
						numarayiSil(Rehber);
					}
				}
			}
			
		}
		
		static void numarayiGuncelle(Dictionary<long,string> Rehber)
		{
			for (int i = 0; i < Rehber.Count; i++) {
				Console.WriteLine("Telefon Numarası: {0}", Rehber.Keys.ElementAt(i));
				Console.WriteLine("-");
			}
			
			Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin telefonunu giriniz:");
			long telefonno = Convert.ToInt64(Console.ReadLine());
			if (Rehber.ContainsKey(telefonno)) {
				
				Console.WriteLine("{0} bulundu. Güncellemek istediğiniz değerleri giriniz", telefonno);
				Console.WriteLine("Yeni İsim: ");
				string ad = Console.ReadLine();
				Console.WriteLine("Yeni Soyisim: ");
				string soyad = Console.ReadLine();
				Console.WriteLine("Yeni Telefon: ");
				long telefon = Convert.ToInt64(Console.ReadLine());
				Rehber.Remove(telefonno);
				Rehber.Add(telefon, ad + " " + soyad);
			}
		}
		
		static void numarayiAra(Dictionary<long,string> Rehber)
		{
			Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
			Console.WriteLine("**********************************************");
			Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
			Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
			int selection = Convert.ToInt32(Console.ReadLine());
			
			
			if (selection == 1) {
				string adSoyad = Console.ReadLine();
				string ad = adSoyad.Split(' ').First();
				string soyad = adSoyad.Split(' ').Last();
	
				/*Console.WriteLine("Girilen Değerler {0}, {1}, {2} {3}",adSoyad,ad,soyad,adSoyad.Reverse());
				Console.WriteLine(Rehber.ContainsValue(adSoyad));
				Console.WriteLine(Rehber.ContainsValue(ad));
				Console.WriteLine(Rehber.ContainsValue(soyad));*/
				if (Rehber.ContainsValue(ad) || Rehber.ContainsValue(soyad) || Rehber.ContainsValue(adSoyad)) {
					string key_holder = "";
					foreach(var item in Rehber){
						if(item.Value == adSoyad){
							key_holder = item.Key.ToString();
						}
					}
					Console.WriteLine("Kişi Bulundu");
					Console.WriteLine("İsim: {0}", adSoyad.Split(' ').First());
					Console.WriteLine("Soyisim: {0}", adSoyad.Split(' ').Last());
					Console.WriteLine("Telefon Numarası: {0}", key_holder);
					Console.WriteLine("-");
					
				}
			} else if (selection == 2) {
				long telefon = Convert.ToInt64(Console.ReadLine());
				if (Rehber.ContainsKey(telefon)) {
					Console.WriteLine("Kişi Bulundu");
					Console.WriteLine("İsim: {0}", Rehber[telefon].Split(' ').First());
					Console.WriteLine("Soyisim: {0}", Rehber[telefon].Split(' ').Last());
					Console.WriteLine("Telefon Numarası: {0}", telefon);
					Console.WriteLine("-");
				}
			}
		}
		
		
		
		public static void Main(string[] args)
		{

			Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
			Console.WriteLine("*******************************************");
			//Menu();
			Dictionary<long, string> Rehber = new Dictionary<long,string>();
			Rehber.Add(59694576540, "Alp Eren");
			Rehber.Add(98765432143, "Ahmet Emre");
			Rehber.Add(34932493223, "Mehmet Tamar");
			Rehber.Add(39492303464, "Ömer Candemir");
			Rehber.Add(93423869345, "Barış Selendiper");
			
			int selection = 0;
			
			do {
				Menu();
				selection = Convert.ToInt32(Console.ReadLine());
				if (selection == 1) {
					numarayiKaydet(Rehber);
				} else if (selection == 2) {
					numarayiSil(Rehber);
					
				} else if (selection == 3) {
					numarayiGuncelle(Rehber);
					
					
				} else if (selection == 4) {
					for (int i = 0; i < Rehber.Count; i++) {
						Console.WriteLine("İsim: {0}", Rehber.Values.ElementAt(i).Split(' ').First());
						Console.WriteLine("Soyisim: {0}", Rehber.Values.ElementAt(i).Split(' ').Last());
						Console.WriteLine("Telefon Numarası: {0}", Rehber.Keys.ElementAt(i));
						Console.WriteLine("-");
					}
					
				} else if (selection == 5) {
					numarayiAra(Rehber);
				}
				
			} while(selection != 0);
			
			Console.ReadLine();
		}
	}
}