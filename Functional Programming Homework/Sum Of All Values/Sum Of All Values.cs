using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

  class SumOfAllValues
    {
        static void Main()
        {
            string keys = Console.ReadLine();
            string text = Console.ReadLine();
            string startKey = "";
            string endKey = "";
            double sum = 0;
            Regex rx = new Regex(@"^([A-Za-z_]+)(\d.*\d)([A-Za-z_]+)$");
                MatchCollection matches = rx.Matches(keys);
                if (matches.Count < 1)
                {
                    Console.WriteLine("<p>A key is missing</p>");
                }
                else
                {
                    foreach (Match match in matches)
                    {
                        GroupCollection groups = match.Groups;
                        startKey += groups[1].Value;
                        endKey += groups[3].Value;
                    }
                    string pattern = "(" + startKey + ")(-?\\d*\\.*?\\d+)(" + endKey + ")";
                    Regex rgx = new Regex(pattern);
                    MatchCollection numMatches = rgx.Matches(text);
                    if (numMatches.Count < 1)
                    {
                        Console.WriteLine("<p>The total value is: <em>nothing</em></p>");
                    }
                    else
                    {
                        foreach (Match match in numMatches)
                        {
                            GroupCollection groups = match.Groups;
                            sum += double.Parse(groups[2].Value);                            
                        }
                        if (sum != 0)
                        {
                            Console.WriteLine("<p>The total value is: <em>{0}</em></p>", sum);
                        }
                        else
                        {
                            Console.WriteLine("<p>The total value is: <em>nothing</em></p>");
                        }
                    }
                }
        }
    }

