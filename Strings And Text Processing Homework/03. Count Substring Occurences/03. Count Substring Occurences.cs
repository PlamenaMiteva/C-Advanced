using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountSubstringOccurences
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        string subStr = Console.ReadLine().ToLower();
        int firstIndex = input.IndexOf(subStr);
        if (firstIndex >= 0)
        {
            int count = 1;
            for (int i = firstIndex + 1; i < input.Length; i++)
            {
                int index = input.IndexOf(subStr, i);
                if (index > 0)
                {
                    count++;
                    i = index;
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

