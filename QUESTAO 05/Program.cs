using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int Y = 0;

            Console.WriteLine("Informe um número inteiro ");
            A = int.Parse(Console.ReadLine());

            if (A > 0)
            {
                Y = A * 2;
                Console.WriteLine("O número informado é positivo/ O dobro desse número é :" + Y);
            }
            else
            {
                Y = A * 3;
                Console.WriteLine("O número informado é negativo/ O triplo é: " + Y);
            }
            Console.ReadLine();
        }
    }
}
