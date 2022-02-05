/*
 * Created by SharpDevelop.
 * User: Alp
 * Date: 2/5/2022
 * Time: 9:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text.RegularExpressions;
using System.Text;


namespace StringBuilderx
{
	class Program
	{
		public static void Main(string[] args)
		{
			StringBuilder sb2 = new StringBuilder("Hello World!",50);
			sb2.Remove(5, 7);
			char[] target = new char[15];
			
			StringBuilder sb = new StringBuilder("Hello World");
			sb.Append(" ");
			sb.AppendLine("C#");
			sb.Append("Yapıyoruz bu sporu. ");
			sb.AppendFormat("{0:F3}",25);
			Console.WriteLine(sb);
			Console.WriteLine("-------------");
			sb.Insert(20," buni ekledim ");
			sb.Remove(20,14);
			Console.WriteLine(sb);
			Console.WriteLine("------------");
			sb.Replace("World","Dünya");
			sb.Replace("C#","C++");
			Console.WriteLine(sb);
			Console.WriteLine("-------------");
			StringBuilder sb3 = new StringBuilder("",60);
			StringBuilder sb4 = new StringBuilder();
			StringBuilder sb5 = new StringBuilder();
			sb3.Append("Kruskal");
			Console.WriteLine(sb3.ToString().GetHashCode());
			sb4.Append("Kruskal");
			Console.WriteLine(sb4.ToString().GetHashCode());
			Console.WriteLine(sb4.Length);
			Console.WriteLine((sb4.Equals(sb3)));
			sb4.CopyTo(2,target,0,5);
			Console.WriteLine(target);
			Console.WriteLine(sb3.Capacity);
			sb3.EnsureCapacity(80);
			Console.WriteLine(sb3.Capacity);
			
			Console.ReadKey(true);
		}
	}
}