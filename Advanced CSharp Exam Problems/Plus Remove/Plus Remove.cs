using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PlusRemove
{
    static void Main()
    {
        List<char[]> result = new List<char[]>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            else
            {
                char[] temp = input.ToCharArray();
                result.Add(temp);
            }
        }
        for (int i = 0; i < result.Count; i++)
        {
            char[] str = result[i];
            string currentStr = String.Empty;
            for (int j = 0; j < str.Length; j++)
            {
                char ch = str[j];

                if (i + 2 < result.Count && j != 0 && j + 1 < result[i + 1].Length &&j<result[i+2].Length&& char.ToLower(ch) == char.ToLower(result[i + 1][j]) && char.ToLower(ch) == char.ToLower(result[i + 1][j - 1]) && char.ToLower(ch) == char.ToLower(result[i + 1][j + 1]) && char.ToLower(ch) == char.ToLower(result[i + 2][j]))
                {
                    continue;
                }
                else if (i != 0 && i + 1 < result.Count && j + 2 < str.Length && j + 1 < result[i + 1].Length && j + 1 < result[i - 1].Length && char.ToLower(ch) == char.ToLower(result[i][j + 1]) && char.ToLower(ch) == char.ToLower(result[i][j + 2]) && char.ToLower(ch) == char.ToLower(result[i - 1][j + 1]) && char.ToLower(ch) == char.ToLower(result[i + 1][j + 1]))
                {
                    continue;
                }
                else if (i != 0 && i + 1 < result.Count && j - 1 >= 0 && j + 1 < str.Length && j < result[i + 1].Length && j < result[i - 1].Length && char.ToLower(ch) == char.ToLower(result[i][j - 1]) && char.ToLower(ch) == char.ToLower(result[i][j + 1]) && char.ToLower(ch) == char.ToLower(result[i - 1][j]) && char.ToLower(ch) == char.ToLower(result[i + 1][j]))
                {
                    continue;
                }
                else if (j - 2 >= 0 && i - 1 >= 0 && i + 1 < result.Count && j - 1 < result[i - 1].Length && j - 1 < result[i + 1].Length && char.ToLower(ch) == char.ToLower(result[i][j - 1]) && char.ToLower(ch) == char.ToLower(result[i][j - 2]) && char.ToLower(ch) == char.ToLower(result[i - 1][j - 1]) && char.ToLower(ch) == char.ToLower(result[i + 1][j - 1]))
                {
                    continue;
                }
                else if (j - 1 >= 0 && i - 2 >= 0 && j < result[i - 2].Length && j + 1 < result[i - 1].Length && char.ToLower(ch) == char.ToLower(result[i - 2][j]) && char.ToLower(ch) == char.ToLower(result[i - 1][j]) && char.ToLower(ch) == char.ToLower(result[i - 1][j - 1]) && char.ToLower(ch) == char.ToLower(result[i - 1][j + 1]))
                {
                    continue;
                }
                else
                {
                    currentStr += ch;
                }

            }
            Console.WriteLine(currentStr);
        }
        Console.ReadLine();
    }
}

