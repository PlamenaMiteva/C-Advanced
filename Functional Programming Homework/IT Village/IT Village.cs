using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ITVillage
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] enteringPos = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
        int[] dice = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
        input = Regex.Replace(input, "\\|", "");
        input = Regex.Replace(input, " ", "");
        StringBuilder matrix = new StringBuilder();
        matrix.Append(input[0]);
        matrix.Append(input[1]);
        matrix.Append(input[2]);
        matrix.Append(input[3]);
        matrix.Append(input[7]);
        matrix.Append(input[11]);
        matrix.Append(input[15]);
        matrix.Append(input[14]);
        matrix.Append(input[13]);
        matrix.Append(input[12]);
        matrix.Append(input[8]);
        matrix.Append(input[4]);
        string board = matrix.ToString();
        int count = board.Count(f => f == 'I');
        int coins = 50;
        int startRow = enteringPos[0] - 1;
        int startCol = enteringPos[1] - 1;
        int position = 0;
        if (startRow==0)
        {
            position = startCol;
        }
        else if (startRow == 3)
        {
            position = 6;
            if (startCol==2)
            {
                position++; 
            }
            if (startCol == 1)
            {
                position+=2;
            }
            if (startCol == 0)
            {
                position+=3;
            }
        }
        else if (startRow == 2&&startCol==0)
        {
            position = 10;
        }
        else if (startRow == 1 && startCol == 0)
        {
            position = 11;
        }
        else
        {
            position = startCol + startRow;
        }
        int inns = 0;
        bool gameOver = false;
        for (int p = 0; p < dice.Length; p++)
        {
            position += dice[p];
            if (position>=board.Length)
            {
                position = position - board.Length;
            }
            if (inns>0 )
            {
                coins += 20; 
            }
            if (board[position] == 'F')
            {
                coins += 20;
            }
            else if (board[position] == 'V')
            {
                coins *= 10;
            }
            else if (board[position] == 'P')
            {
                coins -= 5;
            }
            else if (board[position] == 'N')
            {
                Console.WriteLine("<p>You won! Nakov's force was with you!<p>");
                gameOver = true;
                break;
            }
            else if (board[position] == 'S')
            {
                p+=2;
            }
            else if (board[position] == 'I')
            {
                if (coins>=100)
                {
                    coins -= 100;
                    inns++;
                    matrix[position] = 'M';
                }
                else
                {
                    coins -= 10;
                }
            }
            if (coins<0)
            {
                Console.WriteLine("<p>You lost! You ran out of money!<p>");
                    gameOver=true;
                    break;
            }
            if (count ==inns)
            {
                Console.WriteLine("<p>You won! You own the village now! You have {0} coins!<p>", coins);
                gameOver = true;
                break;
            }
        }
        if (gameOver==false)
        {
            Console.WriteLine("<p>You lost! No more moves! You have {0} coins!<p>", coins);  
        }
    }
}

