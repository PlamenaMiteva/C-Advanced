using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TextFilter
{
    static void Main()
    {
        string[] bannedWords = Console.ReadLine().Split(',').ToArray();
        string text = "It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client";
        for (int i = 0; i < bannedWords.Length; i++)
        {
            string word = bannedWords[i].Trim();
            StringBuilder replaceString = new StringBuilder();
            for (int j = 0; j < word.Length; j++)
            {
                replaceString.Append("*");
            }
            text = text.Replace(word, replaceString.ToString());
        }
        Console.WriteLine(text);
        Console.ReadLine();
    }
}

