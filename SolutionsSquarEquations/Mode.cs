using System;

namespace SolutionsSquarEquations
{
    class Mode
    {
        protected double A = Double.NaN, B = Double.NaN, C = Double.NaN;
        double X1, X2;
        public virtual void ReadData()
        {
            A = 1;
            B = 1;
            C = 1;
        }
        public void SolutionEquations()
        {
            Console.WriteLine($"{A}*x^2+{B}*x+{C}=0");
            double D = B * B - 4 * A * C;
            if (D < 0)
            {
                Console.WriteLine("This example doesn't have root:");
                return;
            }
            else if (D == 0)
            {
                Console.WriteLine("This example has 1 root:");
                X1 = -B / (2 * A);
                Console.WriteLine(X1);
            }
            else
            {
                Console.WriteLine("This example has 2 root:");
                X1 = (-B + Math.Sqrt(D)) / 2 * A;
                X2 = (-B - Math.Sqrt(D)) / 2 * A;
                Console.WriteLine(X1 + "\n" + X2);
            }
        }
    }
}
