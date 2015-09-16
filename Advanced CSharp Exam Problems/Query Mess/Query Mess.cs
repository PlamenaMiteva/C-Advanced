using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class QueryMess
{
    static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            else
            {
                Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
                string[] query = Regex.Split(input, @"&|\?");
                for (int i = 0; i < query.Length; i++)
                {
                    string str = query[i].Replace('+', ' ');
                    string pattern = "%20";
                    string replacement = " ";
                    Regex rgx = new Regex(pattern);
                    str = rgx.Replace(str, replacement);
                    string pat = "\\s+";
                    string repl = " ";
                    Regex rgxs = new Regex(pat);
                    str = rgxs.Replace(str, repl);
                    string[] temp = Regex.Split(str, @"=");
                    if (temp.Length > 1)
                    {
                        string field = temp[0].Trim();
                        string value = temp[1].Trim();
                        if (!result.ContainsKey(field))
                        {
                            List<string> values = new List<string>();
                            values.Add(value);
                            result[field] = values;
                        }
                        else
                        {
                            result[field].Add(value);
                        }
                    }
                }

                foreach (var pair in result)
                {
                    Console.Write(pair.Key + "=[" + String.Join(", ", pair.Value) + "]");
                }
                Console.WriteLine();

            }
        }
        Console.ReadLine();
    }
}

