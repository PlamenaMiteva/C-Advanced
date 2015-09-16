using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

class TextGravity
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        int index = text.Length / size;
        if (text.Length % size != 0)
        {
            index += 1;
        }
        char pad = ' ';
        text = text.PadRight(size * index, pad);
        char[] temp = text.ToCharArray();
        char[,] matrix = new char[index, size];
        int inx = 0;
        for (int a = 0; a < index; a++)
        {
            for (int b = 0; b < size; b++)
            {
                matrix[a, b] = temp[inx];
                inx++;
            }
        }
        for (int row = index - 1; row > 0; row--)
        {
            for (int col = 0; col < size; col++)
            {
                if (matrix[row, col] == ' ')
                {
                    for (int r = row - 1; r >= 0; r--)
                    {
                        if (matrix[r, col] != ' ')
                        {
                            matrix[row, col] = matrix[r, col];
                            matrix[r, col] = ' ';
                            break;
                        }
                    }
                }
            }
        }
        string output = "<table>";
        for (int i = 0; i < index; i++)
        {
            output += "<tr>";
            for (int j = 0; j < size; j++)
            {
                output += "<td>" + SecurityElement.Escape(matrix[i, j].ToString()) + "</td>";
            }
            output += "</tr>";
        }
        output += "</table>";
        Console.WriteLine(output);
    }
}

