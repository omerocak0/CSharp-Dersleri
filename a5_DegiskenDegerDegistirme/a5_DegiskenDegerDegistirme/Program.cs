namespace a5_DegiskenDegerDegistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı Adı: ");
            String kadi = Console.ReadLine();

            Console.Write("e-posta: ");
            String eposta = Console.ReadLine();

            //Değiştirmeden önce bilgiler
            Console.WriteLine("Kullanıcı Adı: " + kadi + " " + "E-posta: " + eposta);

            Console.WriteLine("-----");

            Console.Write("Bilgilerinizi güncellemek istiyor musunuz? (Evet:e, Hayır:h) : ");
            String secim = Console.ReadLine();

            if(secim == "e" || secim == "E")
            {
                Console.Write("Yeni Kullanıcı Adı: ");
                kadi = Console.ReadLine();

                Console.Write("Yeni eposta adresi: ");
                eposta = Console.ReadLine();

            }

            else if(secim == "h" || secim == "H")
            {
                Console.WriteLine("Güncel bilgileriniz");
            }

            //Değitirdikten sonra bilgiler
            Console.WriteLine("Kullanıcı Adı: " + kadi + " " + "E-posta: " + eposta);

            Console.ReadKey();
        }
    }
}
