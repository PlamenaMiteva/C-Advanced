using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NightLife
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, SortedSet<string>>> result = new Dictionary<string, Dictionary<string, SortedSet<string>>>();
        while (true)
        {
            string[] input = Console.ReadLine().Split(';').ToArray();
            if (input[0] == "END")
            {
                break;
            }
            else
            {
                string city = input[0];
                string venue = input[1];
                string performer = input[2];
                if (!result.ContainsKey(city))
                {
                    SortedSet<string> temp = new SortedSet<string>();
                    temp.Add(performer);
                    result[city] = new Dictionary<string, SortedSet<string>>();
                    result[city][venue] = temp;
                }
                else
                {
                    if (!result[city].ContainsKey(venue))
                    {
                        SortedSet<string> temp = new SortedSet<string>();
                        temp.Add(performer);
                        result[city][venue] = temp;
                    }
                    else
                    {
                        result[city][venue].Add(performer);
                    }
                }
            }
        }
        
        foreach (var pair in result)
        {
            string output = "";
            string town = pair.Key;
            output += town;
            foreach (var concert in pair.Value.OrderBy(i => i.Key))
            {
                string stadium = concert.Key;
                output += " -> " + stadium + ": ";
                foreach (var singer in concert.Value)
                {
                    output += singer + ",";
                }
            }
            Console.WriteLine(output.Substring(0, output.Length - 1));
        }
        Console.ReadLine();
    }
}

