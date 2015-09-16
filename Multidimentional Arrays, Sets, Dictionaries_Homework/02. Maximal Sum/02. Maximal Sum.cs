using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MaximalSum
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(n=>int.Parse(n)).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                int[]temp = Console.ReadLine().Split(' ').Select(n=>int.Parse(n)).ToArray();
                for (int j = 0; j < temp.Length; j++)
                {
                    matrix[i, j] = temp[j];
                }
            }
            int biggestSum = int.MinValue;
            int rowIndex = -1;
            int colIndex = -1;
            for (int r = 0; r < matrix.GetLength(0)-2; r++)
            {
                for (int c = 0; c < matrix.GetLength(1)-2; c++)
                {
                    int sum = matrix[r, c] + matrix[r + 1, c] + matrix[r + 2, c] + matrix[r, c + 1] + matrix[r + 1, c + 1] + matrix[r + 2, c + 1] + matrix[r, c + 2] + matrix[r + 1, c + 2] + matrix[r + 2, c + 2];
                    if (sum>biggestSum)
                    {
                        biggestSum = sum;
                        rowIndex = r;
                        colIndex = c;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum = "+biggestSum);
            for (int row = rowIndex; row <rowIndex+3; row++)
            {
                for (int col = colIndex; col <colIndex+3; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

