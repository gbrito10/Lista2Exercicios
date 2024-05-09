using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double media;

            Console.Write("Digite a primeira nota do aluno: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno: ");
            b = double.Parse(Console.ReadLine());

            media = (a + 2 * b) / 3;
            Console.WriteLine("A média do aluno é: ");
            Console.WriteLine(media);

            if (media > 5)
                Console.WriteLine("Aprovado");

            else
                Console.WriteLine("Reprovado");


        }
    }
}
