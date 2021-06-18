using System;

namespace paresConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sumodd;

            x = 1;

            while (x != 0)
            {
                Console.Write("Digite um número inteiro: ");
                x = int.Parse(Console.ReadLine());

                sumodd = 0;

                if (x % 2 == 0)
                {
                    sumodd = (x) + (x + 2) + (x + 4) + (x + 6) + (x + 8);
                }
                else
                {
                    sumodd = (x) + (x + 2) + (x + 4) + (x + 6) + (x + 8) + 5;
                }

                Console.WriteLine("Soma = " + sumodd);
                Console.WriteLine();
            }
        }
    }
}
