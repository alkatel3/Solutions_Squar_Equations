using System;

namespace SolutionsSquarEquations
{
    class OnlineMode : Mode
    {
        public override void ReadDate()
        {
            while (A == 0 || Double.IsNaN(A))
            {
                Console.WriteLine("Input A (A!=0):\t");
                A = ABC(Console.ReadLine());
            }
            while (Double.IsNaN(B))
            {
                Console.WriteLine("Input B  :\t");
                B = ABC(Console.ReadLine());
            }
            while (Double.IsNaN(C))
            {
                Console.WriteLine("Input C :\t");
                C = ABC(Console.ReadLine());
            }
        }
        double ABC(string abc)
        {
            double number = Double.NaN;
            try
            {
                number = Double.Parse(abc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return number;
        }
    }
}
