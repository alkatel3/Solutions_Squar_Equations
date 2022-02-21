using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsSquarEquations
{
    class Mode
    {
        double A, B, C, X1, X2;
        //public Mode(double a, double b, double c)
        //{
        //    A = a;
        //    B = b;
        //    C = c;
        //    Console.WriteLine($"{A}*x^2+{B}*x+{C}=0");
        //}

        public void SolutionEquations()
        {
            double D = B * B - 4 * A * C;
            if (D < 0)
            {
                Console.WriteLine("0");
                return;
            }
            else if (D == 0)
            {
                Console.WriteLine("1");
                X1 = -B / (2 * A);
                Console.WriteLine(X1);
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("2");
                X1 = (-B + Math.Sqrt(D)) / 2 * A;
                X2 = (-B - Math.Sqrt(D)) / 2 * A;
                Console.WriteLine(X1 + "\n" + X2);
            }

        }
    }
}
