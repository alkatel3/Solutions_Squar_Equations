using System;
using System.IO;

namespace SolutionsSquarEquations
{
    class OffLineMode : Mode
    {
        public override async void ReadData()
        {

            while (Double.IsNaN(A) || Double.IsNaN(B) || Double.IsNaN(C))
            {
                Console.WriteLine("Input root (in format: /.../.../.../...):  ");
                try
                {
                    using (StreamReader reader = new StreamReader(Console.ReadLine()))
                    {
                        while (!reader.EndOfStream)
                        {
                            string result = await reader.ReadLineAsync();  // асинхронное чтение из файла
                            string[] ABC = result.Split(" ");
                            for (int i = 0; i < ABC.Length; i++)
                            {
                                ABC[i] = ABC[i].Replace('.', ',');
                            }
                            A = Double.Parse(ABC[0]);
                            B = Double.Parse(ABC[1]);
                            C = Double.Parse(ABC[2]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
