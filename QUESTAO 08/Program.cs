using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Inofrme dez números: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(num);
            Array.Reverse(num);

            foreach (int i in num)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
