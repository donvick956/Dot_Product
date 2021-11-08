using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Product
{
    class MultiplicationOfMatrix
    {
     
        public int multiplyingMatrix()
        {
            int i, j;
            int[,] a = new int[4, 4];
            Console.WriteLine("\t\t\t\tMatrix 4X4 Multiplication Solver");
            Console.WriteLine("Enter numbers of the 4X4 matrix");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("First matrix structure is:");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }


            int[,] b = new int[4, 4];
            Console.WriteLine("Enter numbers of the 4X4 matrix");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("second matrix structure is:");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMultiplication result of the Matrices is:");
            int[,] c = new int[4, 4];
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {


                    c[i, j] = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            return 0;
        }
    }
}