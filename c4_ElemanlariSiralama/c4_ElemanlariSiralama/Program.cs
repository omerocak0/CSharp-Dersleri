namespace c4_ElemanlariSiralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[7]; // Dizi tanımlama

            // Dizi elemanlarını girme
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(i + 1 + ". Eleman: ");
                dizi[i] = int.Parse(Console.ReadLine());
            }

            // Dizi elemanlarını sıralama
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                int enKucuk = i; // En küçük elemanın indeksini tut
                for (int j = i + 1; j < dizi.Length; j++) // Sonuna kadar kontrol et
                {
                    if (dizi[j] < dizi[enKucuk])
                    {
                        enKucuk = j; // Yeni en küçük indeks bulundu
                    }
                }

                // Yer değiştirme işlemi
                if (enKucuk != i)
                {
                    int temp = dizi[i];
                    dizi[i] = dizi[enKucuk];
                    dizi[enKucuk] = temp;
                }
            }

            // Sıralanmış diziyi yazdırma
            Console.WriteLine("Sıralanmış Dizi:");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + "<");
            }

            Console.ReadKey();
        }
    }
}
