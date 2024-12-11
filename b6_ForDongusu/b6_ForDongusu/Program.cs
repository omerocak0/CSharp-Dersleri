namespace b6_ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
		 
		    for (başlangıç; koşul; arttırma veya azaltma;
		 	Koşul Doğru olduğu sürece for işlemi devam eder. 

		    */


            Console.WriteLine("<--TÜM SAYILAR-->");
            for (int i = 0; i<=100; i++)
            {
                Console.WriteLine(i); // 0'dan başlayıp 100'e kadar olan tüm tam sayıları ekrana yazdırır.
            }


            Console.WriteLine("<--ÇİFT SAYILAR-->");
            for (int i = 0; i <= 100; i+=2)
            {
                Console.WriteLine(i); // 0'dan başlayıp 100'e kadar olan tüm ÇİFT tam sayıları ekrana yazdırır.
            }


            Console.WriteLine("<--TEK SAYILAR-->");
            for (int i = 1; i <= 100; i +=2)
            {
                Console.WriteLine(i); // 1'dan başlayıp 100'e kadar olan tüm TEK tam sayıları ekrana yazdırır.
            }

            Console.ReadKey();
        }
    }
}
