using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

    class Palindromes
    {
        static void Main()
        {
            string text = "Hi,exe? ABBA! Hog fully a string. Bob";
            string[] words = Regex.Split(text, @"\?\s?|!\s?|\.\s?|,\s?|\s+");
            List<string> output = new List<string>();
            foreach (string word in words)
            {
                   string reversedString=ReverseString(word);
                            
            if (reversedString.ToString()==word)
            {
                output.Add(word);
            }
            }
            string joinedOutput = String.Join(",", output.ToArray());
            Console.WriteLine(joinedOutput);
            Console.ReadLine();
        }
        public static string ReverseString(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }

    }

