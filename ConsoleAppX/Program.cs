using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppX
{
    internal class Program
    {
        static void calculo(double x, double y, string calc)
        {
            double z = 0;
            switch (calc)
            {
                case "+":
                    z = x + y;
                    break;

                case "-":
                    z = x - y;
                    break;

                case "*":
                    z = x * y;
                    break;

                case "/":
                    z = x / y;
                    break;
            }

            Console.Write("O resultado é: " + z);
        }

        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro número: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a operação\n+ -> Soma\n- -> Subtração\n* -> Multiplicação\n/ -> Divisão");
            string calc = Console.ReadLine().Substring(0, 1);

            calculo(x, y, calc);

            Console.ReadKey();
        }
    }
}
