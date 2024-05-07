using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
                Console.WriteLine("Os dois valores são iguais");

            else
                if (a > b)
                Console.WriteLine("O primeiro valor é maior");

            else
                Console.WriteLine("O segundo valor é maior");
        }
    }
}
