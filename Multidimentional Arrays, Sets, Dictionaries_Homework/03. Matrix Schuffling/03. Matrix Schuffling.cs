using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatrixSchuffling
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        string[,] matrix = new string[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }

        for (int a = 0; a < int.MaxValue; a++)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            if (input[0] == "END")
            {
                PrintMatrix(matrix);
                break;
            }
            if (input[0] != "swap" || input.Length != 5)
            {
                Console.WriteLine("Invalid input");
                continue;
            }
            else
            {
                int x1;
                bool result1 = Int32.TryParse(input[1], out x1);
                int y1;
                bool result2 = Int32.TryParse(input[2], out y1);
                int x2;
                bool result3 = Int32.TryParse(input[3], out x2);
                int y2;
                bool result4 = Int32.TryParse(input[4], out y2);
                if (result1 && result2 && result3 && result4)
                {
                    if (x1 < 0 || x1 >= row || x2 < 0 || x2 >= row || y1 < 0 || y1 >= col || y2 < 0 || y2 >= col)
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }
                    else
                    {
                        string first = matrix[x1, y1];
                        string second = matrix[x2, y2];
                        matrix[x1, y1] = second;
                        matrix[x2, y2] = first;
                        PrintMatrix(matrix);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
            }
        }
        
        Console.ReadLine();
    }
    static void PrintMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,5}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

}

