using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < 20; i++)
        {
            if (i < input.Length)
            {
                output.Append(input[i]);
            }
            else
            {
                output.Append("*");
            }
        }
        Console.WriteLine(output.ToString());
        Console.ReadLine();
    }
}

