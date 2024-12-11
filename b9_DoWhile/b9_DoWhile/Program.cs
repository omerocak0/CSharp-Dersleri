namespace b9_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                do  
                {
                    //Yapılacak işlemler
                } while(koşul);
            */

            // do-while döngüsü, belirli bir kod bloğunu en az bir kez çalıştıran ve daha sonra bir koşulu kontrol eden bir döngü türüdür.

            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < -100);

            Console.ReadKey();
        }
    }
}
