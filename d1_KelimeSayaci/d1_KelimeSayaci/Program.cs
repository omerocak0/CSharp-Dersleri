namespace d1_KelimeSayaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metin giriniz: ");
            string metin = Console.ReadLine();

            int sayac = 1; //çünkü ilk kelime boşluksuz başlar

            for (int i = 0; i<metin.Length; i++)
            {
                if (metin[i] == ' ') //her boşluk bir kelimeyi ayırır
                {
                    sayac++;
                }
            }
            Console.Write("Toplam Kelime Sayısı: " + sayac);

            Console.ReadKey();
        }
    }
}
