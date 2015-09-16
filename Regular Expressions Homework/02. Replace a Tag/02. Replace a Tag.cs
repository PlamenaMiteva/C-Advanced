using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

    class ReplaceATag
    {
        static void Main()
        {
            string input = Console.ReadLine();
            input = Regex.Replace(input, @"\n", "");
            string pat = @"<a\s+href\s?=.+>.+<\/a>";

            // Instantiate the regular expression object.
            Regex r = new Regex(pat, RegexOptions.IgnoreCase);

            // Match the regular expression pattern against a text string.
            Match m = r.Match(input);

            string repl = "";
            while (m.Success)
            {
                string tag = m.ToString();
                string URLtag = Regex.Replace(tag, @"<a", "[URL");
                URLtag = Regex.Replace(URLtag, @"<\/a>", "[/URL]");
                input = input.Replace(tag, URLtag);
                m = m.NextMatch();
            }
            Console.WriteLine(input);
            Console.ReadLine();
        }
    }
