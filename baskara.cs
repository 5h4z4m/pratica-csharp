using System;

namespace Baskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, raiz1, raiz2;

            Console.Write("coeficiente a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("coeficiente b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("coeficiente c: ");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta >= 0)
            {
                raiz1 = (-b - Math.Sqrt(delta)) / 2 * a;
                raiz2 = (-b + Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine();
                Console.WriteLine("Raíz 1: " + raiz1);
                Console.WriteLine("Raíz 2: " + raiz2);
            }
            else
            { 
                Console.WriteLine("A equação não tem raízes reais");
            }
        }
    }
}
