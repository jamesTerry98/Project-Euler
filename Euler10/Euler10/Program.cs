using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler10
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX = 2000000;

            long sum = 0;

            bool[] set = sieveOfEratosthenes(MAX);

            for (int i = 2; i < set.Length; ++i)
            {
                if (set[i]) sum += i;
            }
            Console.Write(sum);
            Console.Read();
        }

        private static bool[] sieveOfEratosthenes(int number)
        {
            // so that we can get set[number],
            // because of the array index starting at 0, not 1
            bool[] set = new bool[number + 1];

            for (int i = 0; i < set.Length; i++)
            {
                set[i] = true;
            }

            for (int i = 2; i < set.Length; i++)
            {
                if (set[i])
                {
                    for (int j = i + i; j < set.Length; j += i)
                    {
                        set[j] = false;
                    }
                }
            }

            return set;
        }
    }
}
