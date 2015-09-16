using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

   class UppercaseWords
    {
        static void Main()
        {
            StringBuilder text=new StringBuilder();
            text.Append(" ");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                else
                {
                    text.Append(input);
                }
            }
            text.Append(" ");
            string str = text.ToString();
            Regex rgx = new Regex(@"([^A-Za-z])([A-Z]+)([^A-Za-z])");
            MatchCollection matches = rgx.Matches(str);
            
    //        List<string> matches = matchCollection
    //.Cast<Match>()
    //.Select(m => m.Groups[2].Value)
    //.Distinct()
    //.ToList();
            foreach (Match match in matches)
            {
                string uppercaseWord = match.Groups[2].Value;
                char[] charArray = uppercaseWord.ToCharArray();
                Array.Reverse(charArray);               
                string reversed = new string(charArray);
                string temp = "";
                if (reversed==uppercaseWord)
                {
                    for (int i = 0; i < uppercaseWord.Length; i++)
                    {
                        temp=temp+uppercaseWord[i]+uppercaseWord[i];
                    }
                    string pattern = String.Format(@"{0}{1}{2}", match.Groups[1].Value, uppercaseWord, match.Groups[3].Value);
                    Regex r = new Regex(pattern);
                    str = r.Replace(str, match.Groups[1].Value + temp + match.Groups[3].Value);
                }
                else
                {
                    string pat = String.Format(@"{0}{1}{2}", match.Groups[1].Value, uppercaseWord, match.Groups[3].Value);
                    Regex reg = new Regex(pat);
                    str = reg.Replace(str, match.Groups[1].Value + reversed + match.Groups[3].Value);
                }

            }
            Console.WriteLine(SecurityElement.Escape(str.Trim()));
        }
    }

