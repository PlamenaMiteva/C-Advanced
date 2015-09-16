using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class SemanticHTML
{
    static void Main()
    {
        List<string> text = new List<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            else
            {
                text.Add(input);
            }
        }
        foreach (var item in text)
	{
                Regex rgx = new Regex(@"(<div)(.*)(id\s*=\s*""|class\s*=\s*"")(header""|nav""|main""|article""|section""|aside""|footer"")(.*)(>)");
                Regex r = new Regex(@"(<\/div>\s*<\s*!--\s*)(nav|header|section|article|main|aside|footer)(\s*--\s*>)");
                if (rgx.IsMatch(item))
                {
                    MatchCollection matches = rgx.Matches(item);
                    string output = String.Empty;
                    foreach (Match match in matches)
                    {
                        string tag = match.Groups[4].Value;
                        output = "<" + tag.Substring(0, tag.Length - 1).Trim();
                        if (match.Groups[2].Value != "" && match.Groups[2].Value != " ")
                        {
                            output += " "+match.Groups[2].Value.Trim();
                        }
                        if (match.Groups[5].Value != "" && match.Groups[5].Value != " ")
                        {
                            output += " " + match.Groups[5].Value.Trim();
                        }
                        output += ">";
                        string repl = " ";
                        output=Regex.Replace(output, @"\s{2,}", repl);
                        Console.WriteLine(output);
                    }
                }
                else if (r.IsMatch(item))
                {
                    MatchCollection matches = r.Matches(item);
                    string output = String.Empty;
                    foreach (Match match in matches)
                    {
                        string tag = match.Groups[2].Value;
                        output = "</" + tag.Trim() + ">";                        
                        Console.WriteLine(output);
                    }
                }
                else
                {
                    Regex.Replace(item, @"\s+", string.Empty);
                    Console.WriteLine(item);
                }
            }
        }
    }


