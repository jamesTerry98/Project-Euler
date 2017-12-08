using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(find(1000));
            Console.Read();
        }

        static int find(int cSquared) {
            for (int a = 1; a < cSquared - 2; a++) {
                for (int b = a + 1; b < cSquared - 1; b++) {
                    for (int c = b + 1; c < cSquared; c++) {
                        if (a + b + c == 1000){
                            double da = a;
                            double db = b; 
                            double dc = c;
                            double ab = Math.Pow(da, 2) + Math.Pow(db, 2);
                            double cs = Math.Pow(dc, 2);
                            if (ab == cs) {
                                return a * b * c;
                            }
                        }
                    }
                }
            }
            return 1;
        }
    }
}
