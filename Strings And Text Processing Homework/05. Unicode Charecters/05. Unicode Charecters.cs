using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class UnicodeCharecters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            byte[] stringBytes = Encoding.Unicode.GetBytes(input);
            char[] stringChars = Encoding.Unicode.GetChars(stringBytes);
            StringBuilder output = new StringBuilder();
            Array.ForEach<char>(stringChars, c => output.AppendFormat("\\u00{0:x}", (int)c));
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }

