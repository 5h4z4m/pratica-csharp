using System;

namespace crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            x = 1;
            y = 0;

            while (x != y)
            {
                Console.WriteLine("Digite dois números: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                
                if (x > y)
                {
                    Console.WriteLine("Decrescente!");
                    Console.WriteLine();
                }
                else if (x < y)
                {
                    Console.WriteLine("Crescente!");
                    Console.WriteLine();
                }
            }

        }
    }
}
