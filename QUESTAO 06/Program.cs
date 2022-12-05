using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 0;
            int Y = 0;

            Console.WriteLine("Infome o primeiro número: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            Y = int.Parse(Console.ReadLine());

            if (X == Y)
            {
                Console.WriteLine(X == Y);
            }
            else
            {
                Console.WriteLine(X == Y);
            }
            Console.ReadLine();

        }
    }
}
