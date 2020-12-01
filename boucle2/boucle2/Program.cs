using System;

namespace boucle2
{
    class Program
    {
        static void Main()
        {
           float num1 = 1;
          
            while (num1 < 10 )
            {
                Console.WriteLine(num1 );
                num1 += num1 / 2;

            }
        }
    }
}
