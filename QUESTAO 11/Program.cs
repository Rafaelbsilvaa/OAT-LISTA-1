using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Operacao = 0;
            double valor = 0;
            double num = 0;
            double vari = 0;

            Console.WriteLine("Qual o valor do produto ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a forma de pagamento ");
            Console.WriteLine();
            Console.WriteLine("1 - À Vista em dinheiro ou cheque ");
            Console.WriteLine("2 - À Vista no cartão de crédito.");
            Console.WriteLine("3 - Em duas vezes parcelado.  ");
            Console.WriteLine("4 - Em duas vezes parcelado mais juros de 10%.");
            Operacao = int.Parse(Console.ReadLine());

            switch (Operacao)
            {
                case 1:
                    num = 0.1 * valor;
                    vari = valor - num;
                    Console.WriteLine("O valor total da compra é: " + vari);
                    break;

                case 2:
                    num = valor * 0.15;
                    vari = valor - num;
                    Console.WriteLine("O valor total da compra: " + vari);
                    break;
                case 3:
                    Console.WriteLine("O valor total da compra dividivo em duas vezes é: " + valor);
                    break;
                case 4:
                    num = valor * 0.1;
                    vari = valor + num;
                    Console.WriteLine("Valor total da compra é:" + vari);
                    break;
            }
            Console.ReadLine();
        }
    }
}
