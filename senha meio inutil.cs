using System;

namespace senha
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.Write("Tente novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido!");
        }
    }
}
