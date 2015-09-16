using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
  class Sentence_Extractor
    {
        static void Main()
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = @"[^?!.]+[!?.]";
            Regex r = new Regex(pattern);
            Match m = r.Match(text);
            while (m.Success)
            {
                string[] sentence= m.ToString().Split(' ').ToArray();
                var index = sentence.Count(c => c == keyword);
                if (index > 0)
                {
                    Console.WriteLine(m.ToString().Trim());     
                }
                m = m.NextMatch();
            }
            Console.ReadLine();
        }
    }

