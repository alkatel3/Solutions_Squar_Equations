using System;

namespace SolutionsSquarEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            byte mode = 3;
            while (mode != 0)
            {
                Console.WriteLine("How do you want to work:\n1. online (click 1)\n2. offline (click 2)");
                try
                {
                    mode = Byte.Parse(Console.ReadLine());
                    if (mode != 1 && mode != 2)
                    {
                        throw new FormatException();
                    }
                }
                catch
                {
                    Console.WriteLine("It isn't corect");
                }
            }
            //var n = new Mode(1, 5, -6);
            //n.SolutionEquations();
        }
    }
}
