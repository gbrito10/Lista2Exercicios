using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p;
            int h;
            double r;

            Console.Write("Digite o peso do paciente: ");
            p = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura do paciente em centímetros: ");
            h = int.Parse(Console.ReadLine());

            r = Math.Pow(h, 2) / p;

            if (r < 20)
                Console.WriteLine("O paciente está abaixo do peso ideal");

            else
            if (r >= 20 && r < 25)
                Console.WriteLine("O paciente está com o peso ideal");

            else
            if (r >= 25) 
            Console.WriteLine("O paciente está acima do peso");





        }
    }
}
