using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para verificar se é primo: ");

            int num = int.Parse(Console.ReadLine());

            string resultado = "O número " + num + " é primo.";

            if (num < 2)
            {
                resultado = "O número " + num + " não é primo.";
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if ((num % i) == 0)
                    {
                        resultado = "O número " + num + " não é primo.";
                    }
                }                
            }

            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
