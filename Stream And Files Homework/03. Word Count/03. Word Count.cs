using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WordCount
{
    static void Main()
    {
        List<string> words = new List<string>();
        using (var reader = new StreamReader("text.txt"))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                var temp = line.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var textWord in temp)
                {
                    words.Add(textWord.ToLower());
                }
                line = reader.ReadLine();
            }
            reader.Close();
        }
        Dictionary<string, int> result = new Dictionary<string, int>();
        using (var reader = new StreamReader("words.txt"))
        {
            string word = reader.ReadLine();
            while (word != null)
            {
                int wordCount = words.Count(textWord => textWord == word);
                result[word] = wordCount;
                word = reader.ReadLine();
            }
            reader.Close();
        }
        result = result.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        using (var writer = new StreamWriter("result.txt"))
        {
            foreach (var pair in result)
            {
                writer.WriteLine(pair.Key + " - " + pair.Value);
            }

        }
    }
}


