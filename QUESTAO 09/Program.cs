using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura = 0;
            string sexo;
            decimal X = 0;

            Console.WriteLine("Qual seu sexo? / F - Feminino e M Masculino");
            sexo = Console.ReadLine();

            Console.WriteLine("Digite a altura ");
            altura = double.Parse(Console.ReadLine());

            if (sexo == "F")
            {
                X = (decimal)((altura * 62.1) - 44.7);
                Console.WriteLine("Peso idela seria : " + X);
            }
            else
            {
                X = (decimal)((altura * 72.7) - 58);
                Console.WriteLine("Peso ideal seria:" + X);
            }
            Console.ReadLine();
        }
    }
}
