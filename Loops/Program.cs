using System;

namespace Loops
{
	class Program
	{
		static void Main(string[] args)
		{

			string kurs1 = "Yazılım Geliştiricis Yetiştirme Kampı";
			string kurs2 = "Programlamaya başlangıç için temel kurs";
			string kurs3 = "Java";
			string kurs4 = "Python";

			Console.WriteLine(kurs1);
			Console.WriteLine(kurs2);
			Console.WriteLine(kurs3);
			Console.WriteLine(kurs4);

			//array = dizi

			string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
				"Programlamaya başlangıç için temel kurs", "Java", "Python", "C#" };

			
			for (int i = 0; i < kurslar.Length; i++)
			{
				Console.WriteLine(kurslar[i]);
			}

			Console.WriteLine("For bitti");
			
			//foreach dizi içerisindeki her bir elemanı için kullanılır
			foreach (string kurs in kurslar) //kurs: takma ad
			{
				Console.WriteLine(kurs);
			}

			Console.WriteLine("sayfa sonu - footer");
		}
	}
}
