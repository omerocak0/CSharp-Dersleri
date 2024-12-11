namespace c7_ArmstrongSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Tanım: Bir n basamaklı sayının Armstrong sayısı olabilmesi için, her bir basamağının 
            n. kuvveti toplamının, sayının kendisine eşit olması gerekir. Yani, bir sayıyı oluşturan 
            rakamların her birinin kuvvetini alıp topladığınızda, bu toplam sayıya eşit oluyorsa, 
            o sayıya Armstrong sayısı denir.

            Örnek:
                153 Sayısı:
                153 sayısının Armstrong sayısı olup olmadığını kontrol edelim.

                153 bir 3 basamaklı bir sayıdır.
                Rakamlar: 1, 5, 3
                Her bir rakamın 3. kuvveti:
                1³ = 1
                5³ = 125
                3³ = 27
                Toplam: 1 + 125 + 27 = 153 olduğundan bir Armstrong sayıdır.
                
            */

            Console.Write("Sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());

            // Sayının basamak sayısını bulma
            int basamakSayisi = sayi.ToString().Length;

            int toplam = 0;
            int geciciSayi = sayi;

            while (geciciSayi > 0)
            {
                int basamak = geciciSayi % 10; // Son basamağı al
                toplam += (int)Math.Pow(basamak, basamakSayisi);  // Kuvvetini al ve ekle
                geciciSayi /= 10; // Bir sonraki basamağa geç
            }

            if (toplam == sayi)
            {
                Console.WriteLine(sayi + " bir Armstrong sayısıdır.");
            }
            else
            {
                Console.WriteLine(sayi + " bir Armstrong sayısı değildir.");
            }


            Console.ReadKey();
        }
    }
}
