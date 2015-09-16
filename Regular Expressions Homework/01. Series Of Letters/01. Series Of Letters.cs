using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pat = @"(.)\1+";

        // Instantiate the regular expression object.
        Regex r = new Regex(pat, RegexOptions.IgnoreCase);

        // Match the regular expression pattern against a text string.
        Match m = r.Match(input);

        string repl = "";
        while (m.Success)
        {
            char[] replacementArray = m.ToString().ToCharArray();
            repl = "" + replacementArray[0];
            input = input.Replace(m.ToString(), repl);
            m = m.NextMatch();
        }
        Console.WriteLine(input);
        Console.ReadLine();
    }
}
