using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int area;

            Console.Write("Digite a base do retângulo: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            b = int.Parse(Console.ReadLine());

            area = (a * b) / 2;

            Console.Write("A área do retângulo é: ");
            Console.WriteLine(area);

            if (area > 100)
                Console.WriteLine("Terreno grande");

            else
                if (area < 100)
                Console.WriteLine("Terreno pequeno");
        }
    }
}
