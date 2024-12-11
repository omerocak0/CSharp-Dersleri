namespace d5_Return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sonuc = Topla(17, 13);  // Topla metodunu çağırıp sonucunu alıyoruz
            Console.WriteLine("Toplam: " + sonuc);  
        }

        public static int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2; 
            return toplam;  // Hesaplanan sonucu geri döndürüyoruz
        }
    }
}
