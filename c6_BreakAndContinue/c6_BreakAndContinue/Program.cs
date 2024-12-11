namespace c6_BreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            break komutu, döngünün (veya switch-case yapısının) hemen sonlandırılmasını sağlar. 
            Döngü, koşul sağlanmasa da break komutu çalıştıktan sonra sona erer ve program bir 
            sonraki kod satırına geçer.

            */

            for(int i = 0; i < 10; i++)
            {
                if(i == 7) // i==7 olduğunda döngü durur.
                {
                    break;                  
                }
                Console.WriteLine(i); 
            }

            /*
            continue komutu, döngüdeki bir iterasyonu atlamak için kullanılır. Yani, döngüdeki 
            şu anki adımı atlar ve döngü bir sonraki adımı çalıştırmaya başlar. Bu, belirli bir 
            koşul altında bazı işlemleri geçmek için kullanılır.

            */
            Console.WriteLine("-----------");

            for(int i = 0;i < 10; i++)
            {
                if(i == 5)  // i==5 olduğunda bu değeri atlar ve devam eder.
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
