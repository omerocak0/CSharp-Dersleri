namespace d6_MetodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Aynı metod adı altında, farklı parametre sayısı veya türleri kullanılarak metodlar tanımlanabilir.

            Aynı isimdeki metodlar farklı dönüş tiplerine sahip olabilir, ancak parametreler farklı olmalıdır.
            */

            topla(21, 34);
            topla(12, 23, 45);
            topla(45, 79, 65, 32);

            Console.ReadKey();
        }

        public static void topla(int sayi1, int sayi2)
        {
            Console.WriteLine("Toplamları: " + (sayi1 + sayi2));
        }

        public static void topla(int sayi1, int sayi2, int sayi3)
        {
            Console.WriteLine("Toplamları: " + (sayi1 + sayi2 + sayi3));

        }
        public static void topla(int sayi1, int sayi2, int sayi3, int sayi4)
        {
            Console.WriteLine("Toplamları: " + (sayi1 + sayi2 + sayi3 + sayi4));
        }
    }
}
