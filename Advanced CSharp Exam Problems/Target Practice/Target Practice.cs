using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TragetPractice
{
    static void Main()
    {
        int[] dimensions = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
        int row = dimensions[0];
        int col = dimensions[1];
        char[,] matrix = new char[row, col];
        char[] input = Console.ReadLine().ToCharArray();
        double[] shotParam = Console.ReadLine().Split(' ').Select(n => double.Parse(n)).ToArray();
        double impactRow = shotParam[0];
        double impactCol = shotParam[1];
        double radius = shotParam[2];
        int index = 0;
        int count = 0;
        for (int i = row - 1; i >= 0; i--)
        {
            if (index == input.Length)
            {
                index = 0;
            }
            if (count % 2 == 0)
            {
                for (int j = col - 1; j >= 0; j--)
                {

                    matrix[i, j] = input[index];
                    index++;
                    if (index == input.Length)
                    {
                        index = 0;
                    }
                }
            }

            else
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[index];
                    index++;
                    if (index == input.Length)
                    {
                        index = 0;
                    }
                }
            }
            count++;
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                int x1 = i;
                int x2 = j;
                double d = Math.Sqrt(Math.Pow((x1 - impactRow), 2) + Math.Pow((x2 - impactCol), 2));
                if (d<=radius)
                {
                    matrix[x1, x2] = '\0';
                }
            }
        }

        for (int i = row - 1; i >= 0; i--)
        {
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] == '\0')
                {
                    for (int c = i - 1; c >= 0; c--)
                    {
                        if (matrix[c,j] != '\0')
                        {
                            matrix[i, j] = matrix[c,j];
                            matrix[c,j] = '\0';
                            break;
                        }

                    }
                }

            }
        }

        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                if (matrix[r, c] != '\0')
                {
                    Console.Write("{0}", matrix[r, c]);
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
