using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_csharp
{
    internal class task2
    {
        public static bool IsPalindrome(int number)
        {
            string numberAsString = number.ToString();

            for (int i = 0; i < numberAsString.Length / 2; i++)
            {
                if (numberAsString[i] != numberAsString[numberAsString.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
