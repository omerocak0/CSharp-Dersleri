namespace b7_WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              int i = 0; // değişken dongunun dışında tanımlanır.
              while(koşul) {
			
				koşul doğru olduğu sürece çalışır
				
				}
            */

            int i = 0;
            while (i <= 100)
            {
                Console.WriteLine(i); // 0'dan başlayıp 100'e kadar 3'ün katı olan sayıları yazdırır.
                i+=3;
            }
            Console.ReadKey();
        }
    }
}
