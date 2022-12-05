using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double V1 = 0;
            double v2 = 0;
            double v3 = 0;
            double oat = 0;
            double ma = 0;
            int cod = 0;

            Console.WriteLine("Informe o código do aluno: ");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a primeira nota: ");
            V1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota: ");
            v3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota das atividade ");
            oat = double.Parse(Console.ReadLine());

            ma = (V1 + (v2 * 2) + (v3 * 3) + oat) / 7;

            if (ma >= 90)
            {
                Console.WriteLine("APROVADO - 'A' - Média final:  " + ma);
            }
            else if (ma >= 75 && ma < 90)
            {
                Console.WriteLine("APROVADO - 'B' - Média final: " + ma);
            }
            else if (ma >= 60 && ma < 75)
            {
                Console.WriteLine("APROVADO - 'C' - Média final: " + ma);
            }
            else if (ma >= 40 && ma < 60)
            {
                Console.WriteLine("REPROVADO - 'D' - Média final: " + ma);
            }
            else
            {
                Console.WriteLine("REPROVADO - 'E' - Média final: " + ma);
            }
            Console.ReadLine();
        }
    }
}
