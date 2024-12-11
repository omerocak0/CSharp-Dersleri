namespace a2_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* OPERATORLER
              + -> Toplama
              - -> Çıkartma
              * -> Çarpma
              / -> Bölme
             
             && -> And 
             || -> Or
             ! -> Not

             ++ -> Artırma
             -- -> Azaltma
             */

            Console.WriteLine(21 + 34);
            Console.WriteLine(56 - 23);
            Console.WriteLine(5 * 6);
            Console.WriteLine(25 / 5);

            Console.WriteLine("---");

            int x = 7;
            int y = 9;
            int z = 34;
            int t = 53;

            Console.WriteLine("x: " + x++); //Önce yazdırır sonra artırır.
            Console.WriteLine("y: " + ++y); //Önce artırır sonra yazdırır.
            Console.WriteLine("z: " + z--); //Önce yazdırır sonra azaltır.
            Console.WriteLine("t: " + --t); //Önce azaltır sonra artırır.

            Console.WriteLine("---");
            //Bundan sonra x ve z değişkenleri yeni değerleri ile yazdırılır
            Console.WriteLine("x: " + x);
            Console.WriteLine("z: " + z);

            Console.ReadKey();
        }
    }
}
