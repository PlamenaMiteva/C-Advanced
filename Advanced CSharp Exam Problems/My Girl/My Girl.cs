using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class MyGirl
{
    static void Main()
    {
        string key = Console.ReadLine();
        string text = "";
        while (true)
        {
            string temp = Console.ReadLine();
            if (temp=="END")
            {
                break;
            }
            else
            {
                text += temp;
            }
        }
        string pattern = "(" + key[0];
        for (int i = 1; i < key.Length - 1; i++)
        {
            char letter = key[i];
            if (!char.IsLetterOrDigit(letter))
            {
                if (letter == '"')
                {
                    pattern += key[i];
                }
                else if (letter == '.' || letter == '?' || letter == '*' || letter == '+' || letter == '$' || letter == '\\' || letter == '('
                    || letter == '{' || letter == '[' || letter == '|' || letter == '^' || letter == ']' || letter == '}' || letter == ')')
                {
                    pattern += "\\" + key[i];
                }
                else
                {
                    pattern += key[i];
                }
            }
            else if (char.IsLetter(letter) && char.IsLower(letter))
            {
                pattern += "[a-z]*";
            }
            else if (char.IsLetter(letter) && char.IsUpper(letter))
            {
                pattern += "[A-Z]*";
            }
            else if (char.IsDigit(letter))
            {
                pattern += "\\d*";
            }
        }
        char last = key[key.Length - 1];
        if (last == '.' || last == '?' || last == '*' || last == '+' || last == '$' || last == '\\' || last == '('
                    || last == '{' || last == '[' || last == '|' || last == '^' || last == ']' || last == '}' || last == ')')
        {
            pattern += "\\" + last + ")";
        }
        else
        {
            pattern += key[key.Length - 1] + ")";
        }
        pattern += "(.{2,6})" + pattern;
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
        {
            Console.Write(match.Groups[2].Value);
        }
        Console.WriteLine();


    }
}

