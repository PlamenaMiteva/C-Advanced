using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


    class LittleJohn
    {
        static void Main()
        {
            int smallArrow = 0;
            int mediumArrow = 0;
            int largeArrrow = 0;
            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                Regex rx = new Regex(@"(>+)(-----)(>+)");
                MatchCollection matches = rx.Matches(input);
                foreach (Match match in matches)
                {
                    GroupCollection groups = match.Groups;
                    string tail = groups[1].Value;
                    string point = groups[3].Value;
                    if (tail.Length>=3 && point.Length>=2)
                    {
                        largeArrrow++;
                    }
                    else if (tail.Length >= 2 && point.Length >= 1)
                    {
                        mediumArrow++;
                    }
                    else
                    {
                        smallArrow++;
                    }
                }
            }
            string temp = smallArrow.ToString() + mediumArrow.ToString() + largeArrrow.ToString();
            int decNum = int.Parse(temp);
            char[] result = Convert.ToString(decNum, 2).ToCharArray();
            string num = new string(result);
            Array.Reverse(result);
            string number = new string(result);
            string str = num + number;
            long output = Convert.ToInt64(str, 2);
            Console.WriteLine(output);
        }
    }

