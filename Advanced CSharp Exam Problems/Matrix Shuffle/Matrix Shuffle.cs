using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class MatrixShuffle
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        char[,] matrix = new char[size, size];
        int row = 0;
        int col = 0;
        string direction = "right";
        int minRow = 0;
        int minCol = -1;
        int maxRow = size;
        int maxCol = size;
        for (int i = 0; i < size*size; i++)
        {
            char ch = ' ';
            if (i < text.Length)
            {
                ch = text[i];
            }
            
            if (col == maxCol && direction == "right")
            {
                col--;
                row++;
                maxCol--;
                direction = "down";
            }
            if (col == minCol && direction == "left")
            {
                col++;
                row--;
                minCol++;
                direction = "up";
            }
            if (row == minRow && direction == "up")
            {
                row++;
                col++;
                minRow++;
                direction = "right";
            }
            if (row == maxRow && direction == "down")
            {
                row--;
                col--;
                maxRow--;
                direction = "left";
            }

            if (direction == "right")
            {
                matrix[row, col] = ch;
                col++;
            }
            else if (direction == "left")
            {
                matrix[row, col] = ch;
                col--;
            }
            else if (direction == "up")
            {
                matrix[row, col] = ch;
                row--;
            }
            else
            {
                matrix[row, col] = ch;
                row++;
            }
        }
        string white = "";
        string black = "";
        bool isWhite = true;
        for (int r = 0; r < size; r++)
        {
            if (size%2==0 &&r>0)
            {
                isWhite = !isWhite;
            }
            for (int c = 0; c < size; c++)
            {
                char letter = matrix[r, c];
                
                    if (isWhite)
                    {
                        white += letter;
                    }
                    else
                    {
                        black += letter;
                    }
                    isWhite = !isWhite;
                }
            
        }
        string temp = white + black;
        string pattern = "[^A-Za-z0-9]";
        string replacement = "";
        Regex rgx = new Regex(pattern);
        string str = rgx.Replace(temp, replacement);
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string result=new string(charArray);        
        if (result.ToLower() == str.ToLower())
        {
            Console.WriteLine("<div style='background-color:#4FE000'>"+temp +"</div>");
        }
        else
        {
            Console.WriteLine("<div style='background-color:#E0000F'>"+temp+"</div>");
        }
    }
}

