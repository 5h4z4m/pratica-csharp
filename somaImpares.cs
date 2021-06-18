using System;

namespace somaImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, sumeven, troca, i;

            Console.WriteLine("Digite dois números:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                troca = x;
                x = y;
                y = troca;
            }

            sumeven = 0;

            for (i = x+1; i < y; i++)
            {
                if (i%2 != 0)
                {
                    sumeven = sumeven + i;
                }
            }

            Console.WriteLine("Soma dos ímpares = " + sumeven);
        }
    }
}
