namespace b2_ifElseBasitHesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Sayı: ");
            double sayi1 = double.Parse(Console.ReadLine());

            Console.Write("2. Sayı: ");
            double sayi2 = double.Parse(Console.ReadLine());

            Console.Write("İşleminiz Seçin (+ - * /) : ");
            string islem = Console.ReadLine();

            if(islem == "+")
            {
                Console.WriteLine(sayi1 + sayi2);
            }

            else if (islem == "-")
            {
                Console.WriteLine(sayi1 - sayi2);
            }

            else if (islem == "*")
            {
                Console.WriteLine(sayi1 * sayi2);
            }

            else if (islem == "/")
            {
                Console.WriteLine(sayi1 / sayi2);
            }

            else
            {
                Console.WriteLine("Geçersiz İşlem");
            }

            Console.ReadKey();
        }
    }
}
