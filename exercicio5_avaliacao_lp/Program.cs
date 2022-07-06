using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5_avaliacao_lp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Fazer um programa para encontrar todos os números pares entre 1 e 100.
            // Eduardo Augusto Nilson Parada RA 6322529

            int op = 1, res;

            while (op <= 100)
            {
                res = op % 2;
                if (res == 0)
                {
                    Console.WriteLine(op);
                    op++;
                }
                else
                {
                    op++;
                }

            }

            Console.ReadKey();
        }
    }
}
