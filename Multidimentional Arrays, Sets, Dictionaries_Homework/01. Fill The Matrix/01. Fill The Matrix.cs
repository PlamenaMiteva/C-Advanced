using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class FillTheMatrix
    {
        static void Main()
        {
            int n= int.Parse(Console.ReadLine());

            //Pattern A
            int[,] matrix = new int[n, n];
            int index = 1;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row,col] = index;
                    index++;
                }
            }
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    Console.Write("{0,3}",matrix[col, row]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //Pattern B
            int[,] matrixB = new int[n, n];
            int indexB = 1;
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrixB[row, col] = indexB;
                        indexB++;
                    }
                }
                else
                {
                    for (int r = n-1; r >=0; r--)
                    {
                        matrixB[r, col] = indexB;
                        indexB++;
                    }
                }
            }
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    Console.Write("{0,3}", matrixB[col, row]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

