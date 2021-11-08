using System;

namespace Dot_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tWelcome to Matrix Calculator");
            Console.WriteLine("Choose any of the Operation\n1: For Matrix Multiplication\n2: " +
                "For Calulating Determinant\n3: For Calculating Dot Product");
            int UserValue = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            if (UserValue == 1)
            {
                MultiplicationOfMatrix multMat = new MultiplicationOfMatrix();
                multMat.multiplyingMatrix();
            }
            else if (UserValue == 2)
            {
                Determinant Delta = new Determinant();
                Delta.Display();
            }
            else if (UserValue == 3)
            {
                MatrixDotProduct Product = new MatrixDotProduct();
                Product.Dot();
            }
            else
            {
                Console.WriteLine("Wrong Digit Entered");
            }


        }
    }
    class MatrixDotProduct
    {
        public void Dot()
        {
            int i, j;
            int[,] A = new int[11, 11];
            int[,] B = new int[11, 11];
            int[] C = new int[11];
            Console.WriteLine("\t\t\t\tMatrix 4X4 Dot Product Finder");
            Console.WriteLine("Enter elements of matrix A:");
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                    A[i, j] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of matrix B:");
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                    B[i, j] = int.Parse(Console.ReadLine());
            for (i = 0; i < 4; i++)
            {
                C[i] = 0;
                for (j = 0; j < 4; j++)
                    C[i] += A[i, j] * B[i, j];

            }
            // Printing matrix A //
            Console.Write("  Structure of Matrix A:\n");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                    Console.Write(A[i, j] + "\t");
                Console.Write("\n");
            }

            // Printing matrix B //
            Console.Write("  Structure of Matrix B:\n");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                    Console.Write(B[i, j] + "\t");
                Console.Write("\n");
            }
            Console.WriteLine("\nThe Matrices Dot product is:");
            for (i = 0; i < 4; i++)
                Console.Write(C[i] + " ");
            Console.ReadKey();
        }
    }
}


