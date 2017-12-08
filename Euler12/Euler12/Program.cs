using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler12
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleNumbers(501);
            Console.Read();
        }

        static int FindTheFactors(long number)
        {
            int factors = 0;
            for (double i =1; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    factors += 2;
                }
            }

            if (Math.Sqrt(number) * Math.Sqrt(number) == number)
            {
                factors -= 2;
            }
            return factors;
        }

        static void TriangleNumbers(int limit)
        {
            long i = 0;
            long total = 0;
            while (FindTheFactors(total) != limit)
            {
                i++;
                total += i;
            }
            Console.Write(total);
        }
    }
}
