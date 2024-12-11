namespace c3_DiziElemanlariniTerstenYazma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[7]; //Dizi tanımlama

            //elemanları alma
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(i+1 + ". Eleman: ");
                dizi[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("----------");
            //ekrana yazdırma
            for(int i = 0;i < dizi.Length;i++)
            {
                Console.Write(dizi[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("----------");
            //elemanları tersten yazma
            for (int i = dizi.Length - 1; i >= 0;i--)
            {
                Console.Write(dizi[i]);
            }
            Console.ReadKey();
        }
    }
}
