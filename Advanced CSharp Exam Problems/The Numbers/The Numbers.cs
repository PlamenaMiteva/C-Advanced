using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


    class TheNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex rx = new Regex(@"\d+");
            MatchCollection matches = rx.Matches(input);
            List<string> result = new List<string>();
            foreach (Match match in matches)
            {
                int num = int.Parse(match.ToString());
                string numHex ="0x"+ num.ToString("X4");
                result.Add(numHex);
               
            }
            Console.WriteLine(string.Join("-", result));

        }
    }

