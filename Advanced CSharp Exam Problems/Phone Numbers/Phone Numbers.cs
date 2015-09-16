using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class PhoneNumbers
{
    static void Main()
    {
        List<string> result = new List<string>();
        string str = "";
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            else
            {
                str += input;
            }
        }
        Regex rx = new Regex(@"([A-Z][A-Za-z]*)([^A-Za-z\+]*?)(\+?\d[0-9\/\.\(\)\-\s]*\d)");
        MatchCollection matches = rx.Matches(str);
        foreach (Match match in matches)
        {
            string phone = match.Groups[3].Value;
            Regex rgx = new Regex("[^0-9\\+]");
            string phoneNum = rgx.Replace(phone, "");
            string output = "<li><b>" + match.Groups[1].Value + ":</b> " + phoneNum + "</li>";
            result.Add(output);
        }

        if (result.Count == 0)
        {
            Console.WriteLine("<p>No matches!</p>");
        }
        else
        {

            Console.WriteLine("<ol>" + string.Join("", result) + "</ol>");

        }
    }
}