namespace b4_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            switch (ifade) {
            case state1:
                // Eğer ifade "state1" değerine eşitse, bu kod çalışır.
            break;

            case state2:
                // Eğer ifade "state2" değerine eşitse, bu kod çalışır.
            break;

            default:
                // Hiçbir durum eşleşmezse, bu kod çalışır.
            break;
            }

            // Notlar:
            1. "break;" her durumda kodun diğer durumlara geçmesini engeller.
            2. "default" isteğe bağlıdır, eşleşme olmazsa çalışır.
            3. Kullanımı, çoklu "if-else" yapısına alternatif olarak daha düzenlidir.

            */


            Console.Write("1-7 arasında bir sayı giriniz: ");
            int gun = Convert.ToInt32(Console.ReadLine());

            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Geçersiz bir sayı girdiniz!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
