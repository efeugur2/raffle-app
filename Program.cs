/*
 * Created by SharpDevelop.
 * User: kurna
 * Date: 5.09.2023
 * Time: 13:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Çekiliş_Programı
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Çekilişe girecek kişi sayısını giriniz :");
			string okunanDeger = Console.ReadLine();
			int kisisayisi = Convert.ToInt32(okunanDeger);
			string[] kisiler = new string[kisisayisi];
			
			for (int i = 0; i < kisisayisi; i++) {
				Console.WriteLine((i+1) + ". Kişinin adını ve soyadını giriniz");
				kisiler[i] = Console.ReadLine();
			}
			
			Console.WriteLine("Kazanan kişi sayısını giriniz :");
			string kazanan = Console.ReadLine();
			int kazanansayisi = Convert.ToInt32(kazanan);
			
			Random rastgele = new Random();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			
			
			for (int i = 0; i < kazanansayisi; i++) {
				int rastgelesayı = rastgele.Next(kisisayisi - 1);
				Console.WriteLine("Tebrikler " + (i+1) + ".talihli :" + kisiler[rastgelesayı] );
				
			}Console.ReadLine();
		}
	}
}