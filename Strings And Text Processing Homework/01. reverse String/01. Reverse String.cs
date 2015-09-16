using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToArray();

            //Method 1. using array
            Array.Reverse(input);
            foreach (char ch in input)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
           // Console.ReadLine();


            //Method 2. using StringBuilder
            string inputStr = Console.ReadLine();
            StringBuilder reversedString = new StringBuilder();
            for (int i = inputStr.Length - 1; i >= 0; i--)
            {
                reversedString.Append(inputStr[i]);
            }
            Console.WriteLine(reversedString.ToString());
            //Console.ReadLine();
        }
    }
}

