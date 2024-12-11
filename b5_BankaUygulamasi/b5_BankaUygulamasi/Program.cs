namespace b5_BankaUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 21000;
            Console.Write("İşlem Seçin " +
                "\n 1-Para Çekme " +
                "\n 2-Para Yatırma " +
                "\n 3-Bakiye Görüntüle " +
                "\n 4-Kredi Başvuru : ");

            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.Write("Çekmek istediğiniz tutar: ");
                    int paraCekme = int.Parse(Console.ReadLine());
                    if (paraCekme <= bakiye)
                    {
                        int yeniBakiye1 = bakiye - paraCekme;
                        Console.Write("İşleminiz Başarıyla Gerçekleşti. Güncel Bakiyeniz: " + yeniBakiye1 + " TL");
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                    }
                    break;

                case 2:
                    Console.Write("Yatırmak istediğiniz tutar: ");
                    int paraYatir = int.Parse(Console.ReadLine());
                    int yeniBakiye2 = paraYatir + bakiye;
                    Console.Write("İşleminiz Başarıyla Gerçekleşti. Güncel Bakiyeniz: " + yeniBakiye2 + " TL");
                    break;

                case 3:
                    Console.WriteLine("Güncel Bakiyeniz: " + bakiye + " TL");
                    break;

                case 4:
                    Console.WriteLine("<--Kredi Başvuru Ekranı-->");
                    Console.Write("Ad Soyad: ");
                    string adSoyad = Console.ReadLine();

                    Console.Write("TC Kimlik No: ");
                    string tcNo = Console.ReadLine();

                    Console.Write("Kredi Tutarı: ");
                    int kredi = int.Parse(Console.ReadLine());

                    Console.Write("Telefon Numarası: ");
                    string telefon = Console.ReadLine();

                    Console.WriteLine("Başvurunuz İşleme Alınmıştır. Sonucu kayıtlı telefon numaranıza iletilecektir.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
