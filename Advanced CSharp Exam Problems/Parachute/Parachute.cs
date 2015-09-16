using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Parachute
{
    static void Main()
    {
        List<string> matrix = new List<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            else
            {
                matrix.Add(input);
            }
        }
        int row = 0;
        int col = 0;
        for (int i = 0; i < matrix.Count; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == 'o')
                {
                    row = i;
                    col = j;
                    break;
                }
            }
        }
        for (int i = row + 1; i < matrix.Count; i++)
        {
            row = i;
            int left = 0;
            int right = 0;
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == '>')
                {
                    right++;
                }
                if (matrix[i][j] == '<')
                {
                    left++;
                }
            }
            col = col - left + right;
            if (matrix[row][col] == '~')
            {
                Console.WriteLine("Drowned in the water like a cat!");
                Console.WriteLine("{0} {1}", row, col);
                break;
            }
                if (matrix[row][col] == '/' || matrix[row][col] == '\\' || matrix[row][col] == '|')
                {
                    Console.WriteLine("Got smacked on the rock like a dog!");
                    Console.WriteLine("{0} {1}", row, col);
                    break;
                }
                if (matrix[row][col] == '_')
                {
                    Console.WriteLine("Landed on the ground like a boss!");
                    Console.WriteLine("{0} {1}", row, col);
                    break;
                }
            }
        }
    }


