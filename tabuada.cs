using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i;

            Console.Write("Deseja saber a tabuada para qual valor? ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(x + " x " + i + " = " + x * i);
            }
        }
    }
}
