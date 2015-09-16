using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class XRemoval
{
    static void Main()
    {
        List<string> result = new List<string>();
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
                result.Add(input);
            }
        }
        for (int i = 0; i < result.Count; i++)
        {
            StringBuilder builder= new StringBuilder();
            for (int j = 0; j < result[i].Length; j++)
            {
                if (i + 2 < result.Count && j + 2 < result[i].Length && j + 1 < result[i + 1].Length && j + 2 < result[i + 2].Length &&
                    char.ToLower(result[i][j]) == char.ToLower(result[i][j + 2]) && char.ToLower(result[i][j]) == char.ToLower(result[i + 1][j + 1]) && char.ToLower(result[i][j]) == char.ToLower(result[i + 2][j]) && char.ToLower(result[i][j]) == char.ToLower(result[i + 2][j + 2]))
                {
                    continue;
                }
                else  if (i + 2 < result.Count &&j-2>=0&& j - 2 < result[i].Length && j - 1 < result[i + 1].Length && j < result[i + 2].Length &&
                    char.ToLower(result[i][j]) == char.ToLower(result[i][j - 2]) && char.ToLower(result[i][j]) == char.ToLower(result[i + 1][j - 1]) && char.ToLower(result[i][j]) == char.ToLower(result[i + 2][j]) && char.ToLower(result[i][j]) == char.ToLower(result[i + 2][j - 2]))
                {
                    continue;
                }
                else if (i - 1 >= 0 && i + 1 < result.Count && j - 1 >= 0 && j + 1 < result[i + 1].Length && j + 1 < result[i - 1].Length &&
                  char.ToLower(result[i][j]) == char.ToLower(result[i - 1][j - 1]) && char.ToLower(result[i][j]) == char.ToLower(result[i - 1][j + 1]) && char.ToLower(result[i][j]) == char.ToLower(result[i + 1][j + 1]) && char.ToLower(result[i][j]) == char.ToLower(result[i + 1][j - 1]))
                {
                    continue;
                }
                else if (i - 2 >= 0 && j + 2 < result[i].Length && j + 1 < result[i - 1].Length && j + 2 < result[i-2].Length &&
                  char.ToLower(result[i][j]) == char.ToLower(result[i][j + 2]) && char.ToLower(result[i][j]) == char.ToLower(result[i - 1][j + 1]) && char.ToLower(result[i][j]) == char.ToLower(result[i - 2][j]) && char.ToLower(result[i][j]) == char.ToLower(result[i - 2][j + 2]))
                {
                    continue;
                }
                else if (i - 2 >= 0 && j - 2 >=0 && j - 1 < result[i - 1].Length && j < result[i - 2].Length &&
                  char.ToLower(result[i][j]) == char.ToLower(result[i][j - 2]) && char.ToLower(result[i][j]) == char.ToLower(result[i - 1][j - 1]) && char.ToLower(result[i][j]) == char.ToLower(result[i - 2][j]) && char.ToLower(result[i][j]) == char.ToLower(result[i - 2][j - 2]))
                {
                    continue;
                }
                else
                {
                    builder.Append(result[i][j]);
                    
                }
            }
            matrix.Add(builder.ToString());
        }
        foreach (var item in matrix)
        {
            Console.WriteLine(item);
        }
    }
}

