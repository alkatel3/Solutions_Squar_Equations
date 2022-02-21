using System;

namespace SolutionsSquarEquations
{
    class Mode
    {
        protected double A = Double.NaN, B = Double.NaN, C = Double.NaN;
        double X1, X2;
        //public Mode(double a, double b, double c)
        //{
        //    A = a;
        //    B = b;
        //    C = c;
        //    Console.WriteLine($"{A}*x^2+{B}*x+{C}=0");
        //}
        public virtual void ReadDate()
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
                Console.WriteLine("1");
                X1 = -B / (2 * A);
                Console.WriteLine(X1);
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
