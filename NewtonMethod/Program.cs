using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.01;
            double x = Input();
            x = Calculate(x, eps);
            Output(x);
            Console.ReadKey();
        }

        private static double Input()
        {
            Console.Write("==========\nx: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        private static double Calculate(double x1, double eps)
        {
            double x2;

            do
            {
                x2 = x1 - FuncD1(x1) / FuncD2(x1);
            }
            while (FuncD1(x2) <= eps);

            return x2;
        }

        private static double Func(double x)
        {
            return 2 * Math.Pow(x - 3, 2) + Math.Pow(Math.E, 0.5 * x);
        }

        private static double FuncD1(double x)
        {
            return 4 * (x - 3) + 0.5 * Math.Pow(Math.E, 0.5 * x);
        }

        private static double FuncD2(double x)
        {
            return 4 + 0.25 * Math.Pow(Math.E, 0.5 * x);
        }

        private static void Output(double x)
        {
            Console.Write("Конечный x: {0:f3}", x);
        }
    }
}
