namespace c2_EnKucukEleman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5]; //5 elemanlı dizi tanımlandı
            
            // For döngüsü ile elemanlara değer atandı
            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(i+1 + ". Sayi: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("-----------");
            //Elemanlar ekrana yazdırıldı
            Console.WriteLine("Dizi Elemanları:");
            for(int i = 0;i < sayilar.Length; i++)
            {
                Console.WriteLine(i + 1 + ". Eleman: " + sayilar[i]);
            }

            Console.WriteLine("-----------");
            //En küçük elemanı bulma
            int enKucuk = sayilar[0];
            for (int i = 1; i < sayilar.Length; i++)
            {
                if (sayilar[i] < enKucuk)
                {
                    enKucuk = sayilar [i];
                }

            }
            Console.WriteLine("En Küçük Eleman: " + enKucuk);

            Console.ReadKey();
        }
    }
}
