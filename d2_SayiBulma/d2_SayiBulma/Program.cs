namespace d2_SayiBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random(); // Random sınıfından bir nesne oluşturuyoruz

            //0 ile 100 arası rastgele bir sayı oluşturur (101 dahil değil)
            int sayi = rastgele.Next(0, 101);
            int sayac = 0;

            for (int i = 0; i < 100 ; i++)
            {
                Console.Write("Tahmininiz: ");
                int tahmin = int.Parse(Console.ReadLine());
                sayac++;

                if (tahmin < sayi)
                {
                    Console.WriteLine("Yanlış! Daha Büyük bir sayı deneyin: ");
                }

                if (tahmin > sayi)
                {
                    Console.WriteLine("Yanlış! Daha Küçük bir sayı deneyin: ");
                }


                else if (tahmin == sayi)
                {
                    Console.WriteLine("Tebrikler Doğru. " + sayac + ". Adımda buldunuz.");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
