namespace c5_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            foreach (veriTuru eleman in dizi)
            {
                // Her eleman üzerinde işlem yapılır
            }
            */

            int[] dizi = { 12, 23, 34, 45, 56, 67 };

            foreach (int i in dizi)
            {
                Console.WriteLine(i+1 + ". Eleman: " + i);
            }

            Console.ReadKey();
        }
    }
}
