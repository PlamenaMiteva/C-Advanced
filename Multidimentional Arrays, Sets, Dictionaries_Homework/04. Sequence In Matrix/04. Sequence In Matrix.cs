using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceInMatrix
{
    static void Main()
    {
        string[,] matrix = new string[,] {
                                   {"ha", "fifi", "ho", "hi"},
                                   {"fo", "ha", "hi", "xx"},
                                   {"xxx", "hi", "h", "xx"},

        };
        int maxLength = 1;
        string max = "";
        //right
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int i = 0; i < matrix.GetLength(1) - 1; i++)
            {
                int currentLength = 1;
                string result = matrix[row, i] + " ";
                for (int j = i + 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[row, j] == matrix[row, i])
                    {
                        currentLength++;
                        result += matrix[row, j] + " ";
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            max = result;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        //down
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int j = 0; j < matrix.GetLength(0) - 1; j++)
            {
                int currentLength = 1;
                string result = matrix[j, col] + " ";
                for (int n = j + 1; n < matrix.GetLength(0); n++)
                {
                    if (matrix[j,col] == matrix[j, n])
                    {
                        currentLength++;
                        result += matrix[j, n] + " ";
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            max = result;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        //right diagonal
        for (int row = 0; row < matrix.GetLength(0)-1; row++)
        {
            for (int i = 0; i < matrix.GetLength(1) - 1; i++)
            {
                int currentLength = 1;
                string result = matrix[row, i] + " ";
                for (int c = i + 1, r=row+1; c < matrix.GetLength(1)&& r < matrix.GetLength(0); c++, r++)
                {
                    if (matrix[row, i] == matrix[r, c])
                    {
                        currentLength++;
                        result += matrix[r, c] + " ";
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            max = result;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        //left diagonal
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int i = matrix.GetLength(1) - 1; i > 0; i--)
            {
                int currentLength = 1;
                string result = matrix[row, i] + " ";
                for (int c = i - 1, r = row + 1; c >= 0 && r < matrix.GetLength(0); c--, r++)
                {
                    if (matrix[row, i] == matrix[r, c])
                    {
                        currentLength++;
                        result += matrix[r, c] + " ";
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            max = result;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        Console.WriteLine(max);
        //Console.WriteLine(maxLength);
        Console.ReadLine();
    }
}

