namespace b3_GununSozu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string soz1 = "Bilgi güçtür. - Francis Bacon";
            string soz2 = "İlim Çin’de de olsa gidip alınız. - Hz. Muhammed (s.a.v)";
            string soz3 = "Bilim ve sanat, aklın en yüce başarılarıdır. - Albert Einstein";
            string soz4 = "İnsanların en hayırlısı, insanlara faydalı olandır. - Hz. Muhammed (s.a.v)";
            string soz5 = "Benim manevi mirasım bilim ve akıldır. - Mustafa Kemal Atatürk";
            string soz6 = "Bilim gerçeklerden hoşlanır, yanılgılardan değil. - Galileo Galilei";
            string soz7 = "Hiç bilenlerle bilmeyenler bir olur mu? - Kur'an-ı Kerim (Zümer Suresi, 9. Ayet)";
            string soz8 = "Bilim sonsuzluğa uzanan bir merdivendir. - Isaac Newton";
            string soz9 = "İnsanı hayvanlardan ayıran özelliği ilimdir. - Hz. Ali (r.a)";
            string soz10 = "Bilim, cehaletin en büyük düşmanıdır. - Nikola Tesla";

            Console.Write("Günün sözü için 1-10 arası bir sayı girin: ");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine(soz1);
            }

            else if (secim == 2)
            {
                Console.WriteLine(soz2);
            }

            else if (secim == 3)
            {
                Console.WriteLine(soz3);
            }

            else if (secim == 4)
            {
                Console.WriteLine(soz4);
            }

            else if (secim == 5)
            {
                Console.WriteLine(soz5);
            }

            else if (secim == 6)
            {
                Console.WriteLine(soz6);
            }

            else if (secim == 7)
            {
                Console.WriteLine(soz7);
            }

            else if (secim == 8)
            {
                Console.WriteLine(soz8);
            }

            else if (secim == 9)
            {
                Console.WriteLine(soz9);
            }

            else if (secim == 10)
            {
                Console.WriteLine(soz10);
            }

            else
            {
                Console.WriteLine("Söz Yok!");
            }
            Console.ReadKey();
        }
    }
}
