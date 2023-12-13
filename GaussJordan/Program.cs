using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_youtube
{
    class jorden
    {
        double[,] arr;
        double var;
        public jorden(int row, int col)
        {
            this.var = row;
            this.arr = new double[row + 1, col + 1];
        }
        public void calc()
        {

            Console.WriteLine("eter the value =");
            for (int i = 0; i < var; i++)
            {
                for (int j = 0; j < var + 1; j++)
                {
                    Console.Write("[{0},{1}] =", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("the matrix =");
            for (int i = 0; i < var; i++)
            {
                for (int j = 0; j < var + 1; j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("the solution =");
            for (int i = 0; i < var; i++)
            {

                double value = (double)arr[i, i];
                for (int j = 0; j < var + 1; j++)
                {

                    arr[i, j] = arr[i, j] / value;
                }
                Console.WriteLine("step 1 =");
                Console.WriteLine(" (1)// arr[i,j] / value");
                for (int q = 0; q < var; q++)
                {
                    for (int j = 0; j < var + 1; j++)
                    {
                        Console.Write("{0}\t", arr[q, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("----------------------------------------");
                for (int k = 0; k < var; k++)
                {
                    value = arr[k, i];
                    if (i != k)
                    {
                        for (int j = 0; j < var + 1; j++)
                        {
                            arr[k, j] = -(value * arr[i, j]) + arr[k, j];
                        }
                    }
                }
                Console.WriteLine("step 2 =");
                Console.WriteLine("if matrix 2*3");
                Console.WriteLine(" (2)// [0,0] *[1,2] + [1,2]");
                Console.WriteLine(" (2)// [0,1] *[1,1] + [1,1]");
                Console.WriteLine("if matrix 3*4");
                Console.WriteLine(" (2)// [0,0] *[1,2] + [1,2] ,,, [0,0] *[2, 1] + [2, 1]");

                Console.WriteLine(" (2)// [2,1] *[1,2] + [2,1] ,,, [0,1] *[1, 2] + [0, 1]");

                Console.WriteLine(" (2)// [1,2] *[0,3] + [0,3] ,,, [2,2] *[1, 2] + [1, 2]");

                for (int q = 0; q < var; q++)
                {
                    for (int j = 0; j < var + 1; j++)
                    {
                        Console.Write("{0}\t", arr[q, j]);
                    }
                    Console.WriteLine();
                }
                for (int a = 0; a < var; a++)
                {
                    value = arr[a, i];
                    if (i != a)
                    {
                        for (int t = 0; t < var + 1; t++)
                        {
                            arr[a, t] = arr[a, t] - value;
                        }
                    }
                }
            }
            Console.WriteLine("finial =");
            for (int q = 0; q < var; q++)
            {
                for (int j = 0; j < var + 1; j++)
                {
                    Console.Write("{0}\t", arr[q, j]);
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter row =");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("enter col =");
            int col = int.Parse(Console.ReadLine());
            jorden j = new jorden(row, col);
            j.calc();
            Console.ReadKey();
        }
    }
}