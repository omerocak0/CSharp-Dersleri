namespace c1_Arrayler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar1 = new int[5]; // 5 elemanlı bir dizi
            sayilar1[0] = 21;           // İlk elemanına değer atama
            sayilar1[1] = 34;           // İkinci elemanına değer atama

            int[] sayilar2 = { 10, 20, 30, 40, 50 }; // Diziyi başlatarak tanımlama

            Console.WriteLine("<-- Birinci Dizi -->");
            for (int i = 0; i < sayilar1.Length; i++)
            {
                Console.WriteLine(i + 1 + ". Eleman: " + sayilar1[i]);
            }

            Console.WriteLine("<-- İkinci Dizi -->");
            for (int i = 0; i < sayilar2.Length; i++)
            {
                Console.WriteLine(i + 1 + ". Eleman: " + sayilar2[i]);
            }

            Console.ReadKey();
        }
    }
}
