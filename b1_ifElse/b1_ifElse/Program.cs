namespace b1_ifElse
{
    internal class Program
    {
        static void Main(string[] args)
		{
			/*

			if(koşul) 
			{
				koşul doğruysa bu bölüm çalışır 
			}
			else if(koşul)
			{
			 	ilk koşul yanlış sonraki koşul doğru ise bu bölüm çalışır.
			}
					
			else 
			{
				kod bloğundaki tüm koşullar yanlış ise bu bölüm çalışır.
			}
			*/

			Console.Write("Vize Notunuz: ");
			int vize = int.Parse(Console.ReadLine());

			Console.Write("Final Notunuz: ");
			int final = int.Parse(Console.ReadLine());

			double ortalama = (vize * 0.4) + (final * 0.6);

			Console.WriteLine("Ortalamanız: " + ortalama);
			if (ortalama >= 90 && final >= 50)
			{
				Console.WriteLine("Geçti AA");
			}

			else if (ortalama >= 80 && final >= 50)
			{
				Console.WriteLine("Geçti BA");
			}

            else if (ortalama >= 70 && final >= 50)
            {
                Console.WriteLine("Geçti BB");
            }

            else if (ortalama >= 60 && final >= 50)
            {
                Console.WriteLine("Geçti BC");
            }

            else if (ortalama >= 50 && final >= 50)
            {
                Console.WriteLine("Geçti CC");
            }

			else
			{
				Console.WriteLine("Kaldı FF");

			}
            Console.ReadKey();
        }
    }
}
