using System;

namespace _seq_duracao
{
    class Program
    {
        static void Main(string[] args)
        {
            int segT, seg, min, hr;

            Console.Write("Digite a duração em segundos: ");
            segT = int.Parse(Console.ReadLine());

            hr = segT / 3600;
            min = (segT - (hr * 3600)) / 60;
            seg = segT - (hr * 3600 + min * 60);

            Console.WriteLine(hr + ":" + min + ":" + seg);
        }
    }
}
