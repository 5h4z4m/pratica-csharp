using System;

namespace _con_coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());

            Console.Write("y = ");
            y = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            { 
                Console.WriteLine("Q1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
        }
    }
}
