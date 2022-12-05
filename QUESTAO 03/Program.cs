using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;

            int calc = 0;

            Console.WriteLine("Programa impar ou par");
            Console.WriteLine("Digite o primeiro valor");
            n1 = int.Parse(Console.ReadLine());
            calc = n1 % 2;

            if (calc == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("o número é impar");
            }
            Console.ReadLine();
        }
    }
}
