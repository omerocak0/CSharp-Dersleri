namespace d4_ParametreliMetod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Sayı: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2. Sayı: ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.Write("İşlem Seçin (+ - * /): ");
            string islem = Console.ReadLine();

            hesapla(sayi1,sayi2,islem);

            Console.ReadKey();
        }

        public static void hesapla(int sayi1, int sayi2, string islem)
        {
            switch(islem)
            {
                case "+":
                    Console.WriteLine(sayi1 + "+"+ sayi2 + "=" + (sayi1+sayi2));
                    break;

                case "-":
                    Console.WriteLine(sayi1 + "-" + sayi2 + "=" + (sayi1 - sayi2));
                    break;

                case "*":
                    Console.WriteLine(sayi1 + "*" + sayi2 + "=" + (sayi1 * sayi2));
                    break;

                case "/":
                    Console.WriteLine(sayi1 + "/" + sayi2 + "=" + (sayi1 / sayi2));
                    break;
            }

        }
    }
}
