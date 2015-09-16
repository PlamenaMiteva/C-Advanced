using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"[A-Za-z0-9][\w.-]*[A-Za-z0-9]@[A-Za-z]+(\.[A-Za-z]+)+";
        Regex r = new Regex(pattern);
        Match m = r.Match(input);
        while (m.Success)
        {
            Console.WriteLine(m.ToString());
            m = m.NextMatch();
        }        
        Console.ReadLine();
    }
}