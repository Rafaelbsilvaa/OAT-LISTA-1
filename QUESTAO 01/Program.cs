using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal A = 0;
            decimal B = 0;
            decimal C = 0;
            decimal soma = 0;
            Console.WriteLine("Soma de valores");
            Console.WriteLine("Digite o valor de A");
            A = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            B = decimal.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor de C ");
            C = decimal.Parse(Console.ReadLine());
            soma = A + B;
            if (soma > C)
            {
                Console.WriteLine(" A soma de A + B é maior que C");
            }
            else
            {
                Console.WriteLine("O valor de C é maior que a soma de A + B");
            }
            Console.ReadLine();
        }
    }
}
