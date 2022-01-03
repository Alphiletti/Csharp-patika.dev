/*
 * Created by SharpDevelop.
 * User: Alp
 * Date: 1/2/2022
 * Time: 10:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ClassFieldMetot
{
	class Program
	{
		public static void Main(string[] args)
		{
			Calisan calisan1 = new Calisan();
			calisan1.ad = "Alp";
			calisan1.soyad = "Eren";
			calisan1.emp_no = 180201074;
			calisan1.department = "İnsan kaynakları";
			
			calisan1.CalisanBilgileri();
			
			Console.ReadKey(true);
		}
	}
	
	class Calisan{
		public string ad;
		public string soyad;
		public int emp_no;
		public string department;
		
		public void CalisanBilgileri(){
			Console.WriteLine("Çalışan Adı: {0}",ad);
			Console.WriteLine("Çalışan Soyadı: {0}",soyad);
			Console.WriteLine("Çalışan Departmanı: {0}",department);
			Console.WriteLine("Çalışan Numarası: {0}",emp_no);

		}
	}
}