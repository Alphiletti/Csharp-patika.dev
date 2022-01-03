/*
 * Created by SharpDevelop.
 * User: Alp
 * Date: 1/2/2022
 * Time: 10:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Kurucu_Fonksiyonlar
{
	class Program
	{
		public static void Main(string[] args)
		{
			Calisan calisan1 = new Calisan("Alp","Eren",180201074,"İnsan Kaynakları");		
			calisan1.CalisanBilgileri();
			
			Calisan calisan2 = new Calisan("Ahmet","Emre");
			calisan2.CalisanBilgileri();
			Console.ReadKey(true);
		}
	}
	
	class Calisan{
		public string Ad;
		public string Soyad;
		public int Emp_no;
		public string Department;
		
		public Calisan(string ad, string soyad, int emp_no, string department){
			this.Ad = ad;
			this.Soyad = soyad;
			this.Emp_no = emp_no;
			this.Department = department;
		}
		public Calisan(string ad, string soyad){
			this.Ad = ad;
			this.Soyad = soyad;
		}
		
		public void CalisanBilgileri(){
			Console.WriteLine("Çalışan Adı: {0}",Ad);
			Console.WriteLine("Çalışan Soyadı: {0}",Soyad);
			Console.WriteLine("Çalışan Departmanı: {0}",Department);
			Console.WriteLine("Çalışan Numarası: {0}",Emp_no);

		}
	}
}