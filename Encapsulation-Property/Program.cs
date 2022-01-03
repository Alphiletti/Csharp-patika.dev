/*
 * Created by SharpDevelop.
 * User: Alp
 * Date: 1/2/2022
 * Time: 10:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Encapsulation_Property
{
	class Program
	{
		public static void Main(string[] args)
		{
			Ogrenci ogrenci1 = new Ogrenci();
			ogrenci1.Isim = "Alp";
			ogrenci1.Soyisim = "Eren";
			ogrenci1.OgrenciNo = 180201074;
			ogrenci1.Sinif = 3;
			ogrenci1.SinifAtlat();
			ogrenci1.OgrenciBilgileriniGetir();
			
			Ogrenci ogrenci2 = new Ogrenci("Ahmet","Emre",256,1);
			ogrenci2.SinifDusur();
			ogrenci2.OgrenciBilgileriniGetir();
			
			Console.ReadKey(true);
			
		}
	}
	
	class Ogrenci{
		private string isim;
		private string soyisim;
		private int sinif;
		private int ogrenciNo;
		
		
		public string Isim {
			get {
				return isim;
			}
			set{
				isim = value;
			}
		}

		public string Soyisim {
			get {
				return soyisim;
			}
			set {
				soyisim = value;
			}
		}

		public int Sinif {
			get {
				return sinif;
			}
			set {
				if(value < 1){
					Console.WriteLine("Sınıf en az 1 olabilir");
					sinif = 1;
				}
				else{
					sinif = value;
				}
				
			}
		}

		public int OgrenciNo {
			get {
				return ogrenciNo;
			}
			set {
				ogrenciNo = value;
			}
		}
		
		public Ogrenci(){}
		public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif){
			Isim = isim;
			Soyisim = soyisim;
			Sinif = sinif;
			OgrenciNo = ogrenciNo;
		}
		
		public void OgrenciBilgileriniGetir(){
			Console.WriteLine("****** Öğrenci Bilgileri ******");
			Console.WriteLine("Öğrenci Adı: {0}",this.Isim);
			Console.WriteLine("Öğrenci Soyadı: {0}",this.Soyisim);
			Console.WriteLine("Öğrenci Numarası: {0}",this.OgrenciNo);
			Console.WriteLine("Öğrenci Sınıfı: {0}\n",this.Sinif);
		}
		
		public void SinifAtlat(){
			this.Sinif = this.Sinif + 1;
		}
		
		public void SinifDusur(){
			this.Sinif = this.Sinif - 1;
		}
	}
}