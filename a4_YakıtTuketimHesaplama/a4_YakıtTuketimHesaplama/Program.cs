namespace a4_YakıtTuketimHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aracınız 100 kilometrede kaç litre yakıt tüketiyor: ");
            double yakit = double.Parse(Console.ReadLine());

            Console.Write("Güncel yakıt litre fiyatını giriniz: ");
            double fiyat = double.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız yolu kilometre cinsinden giriniz: ");
            double alinanYol = double.Parse(Console.ReadLine());

            Console.WriteLine("-----");

            // 1 km de yakılan yakıt miktarı
            double hesap = yakit / 100;

            //Toplam Miktar
            double harcananMiktar = hesap * alinanYol;

            Console.WriteLine("Toplam harcanan yakıt miktarı: " + harcananMiktar + " litre");

            //Toplam tutar
            double harcananTutar = harcananMiktar * fiyat;

            Console.WriteLine("Toplam harcanan yakıt tutarı: " + harcananTutar + " TL");

            Console.ReadKey();
        }
    }
}
