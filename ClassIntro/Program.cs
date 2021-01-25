using System;

namespace ClassIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			string adi = "Mehmet";
			int yas = 25;

			Kurs kurs1 = new Kurs();
			kurs1.KursAdi = "C#";
			kurs1.Egitmen = "Fırat Demir";
			kurs1.IzlenmeOrani = 68;


			Kurs kurs2 = new Kurs();
			kurs2.KursAdi = "Python";
			kurs2.Egitmen = "Alp Kağan";
			kurs2.IzlenmeOrani = 72;


			Kurs kurs3 = new Kurs();
			kurs3.KursAdi = "Java";
			kurs3.Egitmen = "Salih Bahçe";
			kurs3.IzlenmeOrani = 55;


			Kurs kurs4 = new Kurs();
			kurs4.KursAdi = "C++";
			kurs4.Egitmen = "Ali Kaçar";
			kurs4.IzlenmeOrani = 89;

			//Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

			Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

			foreach (var kurs in kurslar)
			{
				Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
			}




			//Console.WriteLine("Hello World!");
		}
	}

	class Kurs
	{
		public string KursAdi { get; set; }
		public string Egitmen { get; set; }
		public int IzlenmeOrani { get; set; }
	}
}
