using System;

namespace _seq_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, altura, area, perimetro, diagonal;

            Console.Write("Base do retângulo: ");
            largura = double.Parse(Console.ReadLine());

            Console.Write("Altura do retângulo: ");
            altura = double.Parse(Console.ReadLine());

            area = altura * largura;
            perimetro = 2 * altura + 2 * largura;
            diagonal = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(largura, 2));

            Console.WriteLine("area = " + area);
            Console.WriteLine("perimetro = " + perimetro);
            Console.WriteLine("diagonal = " + diagonal.ToString("F4"));
        }
    }
}
