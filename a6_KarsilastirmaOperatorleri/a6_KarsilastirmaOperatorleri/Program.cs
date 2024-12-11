namespace a6_KarsilastirmaOperatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
            == --> Eşittir.

            != --> Eşit değil

            < --> Küçüktür.

            > --->Büyüktür.

            <= --> Küçük veya eşit

            >= --> Büyük veya eşit 
            
             */

            int a = 7, b = 9;

            // Doğruysa True, Yanlışsa False döndürür.
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);

            Console.ReadKey();
        }
    }
}
