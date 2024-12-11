namespace b8_BinaryDonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İkili sayı sistemine dönüştürmek istediğiniz sayıyı girin: ");
            int sayi = int.Parse(Console.ReadLine());

            string ikiliSayı = "";

            while (sayi > 0)
            {
                int kalan = sayi % 2; // mod alma ile kalan bulma.
                ikiliSayı += kalan;
                sayi = sayi / 2;
            }

            Console.WriteLine(sayi + "'nin ikili sistemdeki karşılığı: " + ikiliSayı);

            Console.ReadKey();
        }
    }
}
