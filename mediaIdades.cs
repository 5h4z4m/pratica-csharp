using System;

namespace mediaIdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, somaidade, pessoas;
            double media;

            Console.WriteLine("Digite as idades: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 0)
            {
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                somaidade = 0;
                pessoas = 0;

                while (idade >= 0)
                {
                    somaidade = somaidade + idade;
                    pessoas = pessoas + 1;

                    idade = int.Parse(Console.ReadLine());
                }

                media = (double)somaidade / pessoas;

                Console.WriteLine("Media = " + media.ToString("F2"));
            }
        }
    }
}
