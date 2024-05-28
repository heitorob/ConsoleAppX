using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoParametrosII
{
    internal class Program
    {
        static double calculo(double x, double y, string calc)
        {
            switch (calc)
            {
                case "+":
                    return x + y;

                case "-":
                    return x - y;

                case "*":
                    return x * y;

                case "/":
                    return x / y;

                default:
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro número: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a operação\n+ -> Soma\n- -> Subtração\n* -> Multiplicação\n/ -> Divisão");
            string calc = Console.ReadLine().Substring(0, 1);

            Console.WriteLine("O resultado é: " + calculo(x, y, calc));

            Console.ReadKey();
        }
    }
}
