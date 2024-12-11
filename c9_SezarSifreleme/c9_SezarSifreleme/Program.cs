namespace c9_SezarSifreleme
{
    internal class Program
    {
        public static char[] alfabe = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k' ,'l',
                                        'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };

        public static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
                                'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static void Main(string[] args)
        {
            Console.WriteLine("1. Şifreleme");
            Console.WriteLine("2. Şifre Çözme");
            Console.Write("Lütfen bir seçenek seçin (1 veya 2): ");

            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Sifreleme();
            }
            else if (secim == "2")
            {
                Desifreleme();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim");
            }

        }

        static void Sifreleme()
        {
            Console.WriteLine("1. Türkçe Alfabe");
            Console.WriteLine("2. İngilizce Alfabe");
            Console.Write("Lütfen bir seçenek seçin (1 veya 2): ");

            string secim2 = Console.ReadLine();
            if (secim2 == "1")
            {
                Console.Write("Şifrelenmek istenen metin: ");
                string acikMetin = Console.ReadLine();

                Console.Write("Katsayı: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Sabit Değer: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("Şifreli Metin: ");
                char temp;
                foreach (char c in acikMetin.ToLower())
                {
                    temp = c;
                    for (int i = 0; i < alfabe.Length; i++)
                    {
                        if (c == alfabe[i])
                        {
                            temp = alfabe[(a * i + b) % alfabe.Length];
                            break;
                        }
                    }
                    Console.Write(temp);
                }
            }

            else if (secim2 == "2")
            {
                Console.Write("Şifrelenmek istenen metin: ");
                string acikMetin = Console.ReadLine();

                Console.Write("Katsayı: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Sabit Değer: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("Şifreli Metin: ");
                char temp;
                foreach (char c in acikMetin.ToLower())
                {
                    temp = c;
                    for (int i = 0; i < alphabet.Length; i++)
                    {
                        if (c == alphabet[i])
                        {
                            temp = alphabet[(a * i + b) % alphabet.Length];
                            break;
                        }
                    }
                    Console.Write(temp);
                }
            }

            Console.WriteLine();
        }

        static void Desifreleme()
        {
            Console.WriteLine("1. Türkçe Alfabe");
            Console.WriteLine("2. İngilizce Alfabe");
            Console.Write("Lütfen bir seçenek seçin (1 veya 2): ");

            string secim3 = Console.ReadLine();
            if (secim3 == "1")
            {
                Console.Write("Çözülmek istenen metin: ");
                string sifreliMetin = Console.ReadLine();

                Console.Write("Katsayı: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Sabit Değer: ");
                int b = int.Parse(Console.ReadLine());

                // Modüler ters bulma (şifre çözmek için a'nın tersini bulmalıyız)
                int modInverse = ModularInverse(a, alfabe.Length);

                if (modInverse == -1)
                {
                    Console.WriteLine("Hata: Katsayının modüler tersi bulunamadı. Geçersiz a değeri.");
                    return;
                }

                Console.Write("Açık Metin: ");
                char temp;
                foreach (char c in sifreliMetin.ToLower())
                {
                    temp = c;
                    for (int i = 0; i < alfabe.Length; i++)
                    {
                        if (c == alfabe[i])
                        {
                            int index = (modInverse * (i - b + alfabe.Length)) % alfabe.Length;
                            temp = alfabe[index];
                            break;
                        }
                    }
                    Console.Write(temp);
                }
            }

            else if (secim3 == "2")
            {
                Console.Write("Çözülmek istenen metin: ");
                string sifreliMetin = Console.ReadLine();

                Console.Write("Katsayı: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Sabit Değer: ");
                int b = int.Parse(Console.ReadLine());

                // Modüler ters bulma (şifre çözmek için a'nın tersini bulmalıyız)
                int modInverse = ModularInverse(a, alphabet.Length);

                if (modInverse == -1)
                {
                    Console.WriteLine("Hata: Katsayının modüler tersi bulunamadı. Geçersiz a değeri.");
                    return;
                }

                Console.Write("Açık Metin: ");
                char temp;
                foreach (char c in sifreliMetin.ToLower())
                {
                    temp = c;
                    for (int i = 0; i < alphabet.Length; i++)
                    {
                        if (c == alphabet[i])
                        {
                            int index = (modInverse * (i - b + alphabet.Length)) % alphabet.Length;
                            temp = alphabet[index];
                            break;
                        }
                    }
                    Console.Write(temp);
                }
            }

            Console.WriteLine();
        }

        static int ModularInverse(int a, int mod)
        {
            a = a % mod;
            for (int x = 1; x < mod; x++)
            {
                if ((a * x) % mod == 1)
                {
                    return x;
                }
            }
            return -1; // Ters bulunamadı
        }
    }
}