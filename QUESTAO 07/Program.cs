using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um nuemro inteiro");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar!");
            }
            Console.WriteLine(" numero é" + x);
            Console.ReadLine();
        }
    }
}
