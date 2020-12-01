using System;

namespace Atelier.variables
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("saisie le nom de produit ");
            string pName = Console.ReadLine() ;
            Console.WriteLine("saisie le prix du produit ");
           float prix = float.Parse(Console.ReadLine());
            Console.WriteLine("  Produit : " + pName + " , son prix est : " + prix );
            Console.WriteLine("  Le prix du : " + pName + " , est de : " + prix * 1.19);


        }

    }
}
