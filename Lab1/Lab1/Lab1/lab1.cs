using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class NumberMatrix
    {
        private int N { get; set; }
        private int A { get; set; }
        private int B { get; set; }

        private int[,] matrix;

        public NumberMatrix(int n, int a, int b)
        {
            N = n;
            A = a;
            B = b;
            matrix = new int[N, N];

            FillMatrix();
        }

        private void FillMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(A, B + 1);
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int GetOddCount()
        {
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
    internal class lab1
    {
        static void Main(string[] args)
        {
            int nSize = 3;
            int minVal = 1;
            int maxVal = 5;

            NumberMatrix myMatrix = new NumberMatrix(nSize, minVal, maxVal);

            myMatrix.ShowMatrix();

            int oddCount = myMatrix.GetOddCount();
            Console.WriteLine($"\nOdd numbers count: {oddCount}");
        }
    }
}