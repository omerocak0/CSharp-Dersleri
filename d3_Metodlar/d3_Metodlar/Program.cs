namespace d3_Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            faktoriyel(); // Faktoriyel metodunu çağırıyoruz

            Console.ReadKey();
        }

        // Faktoriyel hesaplayan metod
        public static void faktoriyel()
        {
            Console.Write("Faktöriyelini hesaplamak istediğiniz sayı: ");
            int sayi = int.Parse(Console.ReadLine());
            int fak = 1;

            for (int i = sayi; i > 1; i--)
            {
                fak *= i;
            }
            Console.WriteLine(sayi + "'nin faktöriyeli: " + fak);
        }
    }
}
