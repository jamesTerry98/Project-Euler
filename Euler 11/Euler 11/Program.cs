using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Euler_11
{
    class Program
    {
        static int[,] NumArray2d = new int[20,20];
        static int max = 0;
        static void Main(string[] args)
        {
            GetFile("C:/Users/james.terry/source/repos/Euler 11/Euler 11/Table.txt");
            SearchRight();
            SearchDown();
            SearchDiagonal();
            SearchDiagonalLeft();
            Console.WriteLine(max);
            //arraywrite();
            Console.Read();
        }

        static void GetFile(String filepath) {
            String lines = File.ReadAllText(filepath);
            lines = lines.Replace("\r\n", " ");
            String[] numbers = lines.Split(' ');
            int[] NumArray = Array.ConvertAll(numbers, ss => int.Parse(ss));
            for (int i = 0; i < 400; i++) {
                NumArray2d[i/20, i % 20] = NumArray[i];
            }
        }

        static void SearchRight() {
            for (int i = 0; i < 20; i++) {
                for (int j = 0; j < 16; j++) {
                    int total = 0;
                    for (int n = 0; n < 4; n++) {
                        total += NumArray2d[i, j+n];
                    }
                    if (total > max){ max = total; }
                }
            }
        }

        static void SearchDown() {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    int total = 0;
                    for (int n = 0; n < 4; n++)
                    {
                        total += NumArray2d[j+n, i];
                    }
                    if (total > max) { max = total; }
                }
            }
        }

        static void SearchDiagonal(){
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    int total = 1;
                    for (int n = 0; n < 4; n++)
                    {
                        total = total * NumArray2d[i+n , j+n];
                    }
                    if (total > max) { max = total; }
                }
            }
        }

        static void SearchDiagonalLeft()
        {
            for (int i = 4; i < 20; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    int total = 1;
                    for (int n = 0; n < 4; n++)
                    {
                        total = total * NumArray2d[i - n, j + n];
                    }
                    if (total > max) { max = total; }
                }
            }
        }


        static void arraywrite() {
            int rowLength = NumArray2d.GetLength(0);
            int colLength = NumArray2d.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", NumArray2d[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }
    }
}
