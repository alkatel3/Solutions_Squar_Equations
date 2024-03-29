﻿using System;
namespace SolutionsSquarEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            byte? NumberMode = null;
            Mode ClassMode;
            while (NumberMode == null)
            {
                Console.WriteLine("How do you want to work:\n" +
                    "1. online (click 1)\n" +
                    "2. offline (click 2)\n" +
                    "0. Exit (click 0)");
                try
                {
                    NumberMode = Byte.Parse(Console.ReadLine());
                    if (NumberMode != 1 && NumberMode != 2 && NumberMode != 0)
                    {
                        throw new FormatException();
                    }
                }
                catch
                {
                    Console.WriteLine("It isn't corect");
                }
            }
            if (NumberMode == 1)
            {
                ClassMode = new OnLineMode();
            }
            else if (NumberMode == 2)
            {
                ClassMode = new OffLineMode();
            }
            else
            {
                return;
            }
            ClassMode?.ReadData();
            ClassMode?.SolutionEquations();
        }
    }
}
