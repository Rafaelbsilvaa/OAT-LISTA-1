using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            string Sexo;
            string Estado;
            int tempo;

            Console.WriteLine(" Qual seu nome");
            Nome = Console.ReadLine();
            Console.WriteLine("Qual seu sexo");
            Sexo = Console.ReadLine();
            Console.WriteLine("Qual seu estado civil");
            Estado = Console.ReadLine();
            if ((Sexo == "f") && (Estado == "casada"))
            {
                Console.WriteLine("Digite o tempo de casamento");
                tempo = int.Parse(Console.ReadLine());

            }
            Console.ReadLine();
        }
    }
}
