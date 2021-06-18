using System;

namespace experiencias
{
    class Program
    {
        static void Main(string[] args)
        {
            char cobaia;
            double percentualC, percentualS, percentualR;
            int tC, tS, tR, tT, nC, i, x;

            Console.Write("Quantos casos serão digitados? ");
            nC = int.Parse(Console.ReadLine());

            tT = 0;
            tC = 0;
            tR = 0;
            tS = 0;

            for (i = 0; i < nC; i++)
            {
                Console.Write("Quantidade de cobaias: ");
                x = int.Parse(Console.ReadLine());

                tT = tT + x;

                Console.Write("Tipo de cobaia: ");
                cobaia = char.Parse(Console.ReadLine());

                if (cobaia == 'C')
                {
                    tC = tC + x;
                }
                else if (cobaia == 'R')
                {
                    tR = tR + x;
                }
                else if (cobaia == 'S')
                {
                    tS = tS + x;
                }
            }

            percentualC = ((double)tC / tT) * 100;
            percentualR = ((double)tR / tT) * 100;
            percentualS = ((double)tS / tT) * 100;

            Console.WriteLine();
            Console.WriteLine("Relatório Final:");
            Console.WriteLine("Total: " + tT);
            Console.WriteLine("Total de Coelhos: " + tC);
            Console.WriteLine("Total de Ratos: " + tR);
            Console.WriteLine("Total de Sapos: " + tS);
            Console.WriteLine("Percentual de Coelhos: " + percentualC.ToString("F2"));
            Console.WriteLine("Percentual de Ratos: " + percentualR.ToString("F2"));
            Console.WriteLine("Percentual de Sapos: " + percentualS.ToString("F2"));
        }
    }
}
