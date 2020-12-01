using System;

namespace calculatrice
{
    class Program
    {
        static int Main(string[] args)
        {
            int a, b;
            string choice;
            float result = 0;
            while (true)
            {
                Console.WriteLine("saisie le premier nombre ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("saisie la deuxiéme nombre ");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("+. Addition ");
                Console.WriteLine("-. Subtraction ");
                Console.WriteLine("*. Multiplication ");
                Console.WriteLine("/. Division ");
                Console.WriteLine("%. Reste ");
                Console.WriteLine("Q. Quitter ");
                Console.WriteLine(" choisie l'opération : ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "*":
                        result = a * b;
                        break;
                    case "/":
                        result = a / b;
                        break;
                    case "%":
                        result = a % b;
                        break;
                    case "Q":
                        return 0;
                    default:
                        Console.WriteLine("choix incorrect");
                        break;
                }
                Console.WriteLine(a.ToString() + " " + choice + " " + b.ToString() + " = " + result.ToString());
                Console.ReadKey();

            }

        }
    }
}
