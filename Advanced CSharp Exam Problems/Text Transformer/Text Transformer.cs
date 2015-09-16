using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        StringBuilder text= new StringBuilder();
        StringBuilder builder = new StringBuilder();
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "burp")
            {
                break;
            }
            else
            {
                text.Append(command);
            }
        }
        string pattern = "\\s+";
        string replacement = " ";
        Regex rgx = new Regex(pattern);
        string result = rgx.Replace(text.ToString(), replacement);
        Regex r = new Regex(@"(\$)([^\$\&'\%]+)(\$)|(\%)([^\$\&'\%]+)(\%)|(\&)([^\$\&'\%]+)(\&)|(')([^\$\&'\%]+)(')");
        MatchCollection matches = r.Matches(result);
        int weight = 0;
        foreach (Match match in matches)
        {
            string line = match.Groups[2].Value;
            weight = 1;
            if (line=="")
            {
                line = match.Groups[5].Value;
                weight = 2;
            }
            if (line == "")
            {
                line = match.Groups[8].Value;
                weight = 3;
            }
            if (line == "")
            {
                line = match.Groups[11].Value;
                weight = 4;
            }
            
                
            
            
            for (int i = 0; i < line.Length; i++)
            {
                if (i%2==0)
                {
                    int number = (int)line[i] + weight;
                    builder.Append((char)number);

                }
                else
                {
                    int number = (int)line[i] - weight;
                    builder.Append((char)number);
                }
            }
            builder.Append(" ");
        }
        Console.WriteLine(builder.ToString());
    }
}

