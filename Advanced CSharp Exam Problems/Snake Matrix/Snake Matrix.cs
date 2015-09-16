using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SnakeMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        int number = 1;
        for (int row = 0; row < n; row++)
        {
            //if the row is even start from the beginning
            if (row % 2 == 0)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = number;
                    number++;
                }
            }
            //if the row is odd start from the end
            else
            {
                for (int col = m-1; col>=0; col--)
                {
                    matrix[row, col] = number;
                    number++;
                }
            }
        }
        //print matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }

    }
}


