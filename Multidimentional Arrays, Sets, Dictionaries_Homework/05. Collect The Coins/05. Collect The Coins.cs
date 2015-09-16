using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CollectTheCoins
{
    static void Main()
    {
        char[][] board = new char[4][];
        for (int i = 0; i < board.GetLength(0); i++)
        {
            string temp = Console.ReadLine();
            char[] input = new char[temp.Length];
            int index = 0;
            foreach (var item in temp)
            {
                input[index] = item;
                index++;
            }

            board[i] = new char[input.Length];

            for (int j = 0; j < board[i].Length; j++)
            {
                board[i][j] = input[j];
            }
        }
        string dir = Console.ReadLine();
        char[] direction = new char[dir.Length];
        int pos = 0;
        foreach (var item in dir)
        {
            direction[pos] = item;
            pos++;
        }
        int row = 0;
        int col = 0;
        int coins = 0;
        int walls = 0;
        for (int d = 0; d < direction.Length; d++)
        {
            if (direction[d]=='>')
            {
                col++;
            }
            if (direction[d] == '<')
            {
                col--;
            }
            if (direction[d] == '^')
            {
                row--;
            }
            if (direction[d] == 'v')
            {
                row++;
            }
            
            if (row<0)
            {
                walls++;
                row++;
            }
            if (row >3)
            {
                walls++;
                row--;
            }
            if (col < 0)
            {
                walls++;
                col++;
            }
            if (col >board[row].Length-1)
            {
                walls++;
                col--;
            }
            if (board[row][col] == '$')
            {
                coins++;
            }
        }
        Console.WriteLine("Coins collected: "+coins);
        Console.WriteLine("Walls hit: " + walls);
        Console.ReadLine();
    }
}


