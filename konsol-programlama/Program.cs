using System;

namespace konsol_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Girin:");
            string fname = Console.ReadLine();
            Console.WriteLine("Soyisminizi Girin:");
            string sname = Console.ReadLine();
            Console.WriteLine($"Merhaba {fname} {sname} ");
            Console.ReadLine();
        }
    }
}
