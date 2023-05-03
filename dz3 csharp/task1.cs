using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_csharp
{
    internal class task1
    {
        public static void DrawSquare(int sideLength, char symbol)
        {
            if (sideLength % 2 == 0)
            {
                Console.WriteLine("Довжина сторони повинна бути непарним числом!");
                return;
            }

            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    if (i == 0 || i == sideLength - 1 || j == 0 || j == sideLength - 1)
                    {
                        Console.Write(symbol + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
