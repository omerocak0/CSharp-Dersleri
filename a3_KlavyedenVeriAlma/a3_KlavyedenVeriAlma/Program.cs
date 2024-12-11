namespace a3_KlavyedenVeriAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ad: ");
            String ad = Console.ReadLine();

            Console.Write("Soyad: ");
            String soyad = Console.ReadLine();

            Console.Write("Yaş: ");
            int yas = int.Parse(Console.ReadLine());

            Console.Write("e-posta: ");
            String eposta = Console.ReadLine();

            Console.Write("Telefon: ");
            String telefon = Console.ReadLine();


            Console.WriteLine("-----");
            Console.WriteLine("Kişisel Bilgiler");
            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad: " + soyad);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("E-posta: " + eposta);
            Console.WriteLine("Telefon: " + telefon);

            Console.ReadKey();
        }
    }
}
