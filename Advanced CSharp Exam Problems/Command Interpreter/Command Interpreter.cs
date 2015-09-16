using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class CommandInterpreter
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, object>> storage = new Dictionary<string, Dictionary<string, object>>();
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "report")
            {
                break;
            }
            else
            {
                string[] str = input.Split('|').ToArray();
                string name = str[0];
                string countryName = str[1];
                string pattern = "\\s+";
                string replacement = " ";
                Regex rgx = new Regex(pattern);
                string player = rgx.Replace(name, replacement);
                string country = rgx.Replace(countryName, replacement);
                country = country.Trim();
                player = player.Trim();
                    if (!storage.ContainsKey(country))
                    {
                        storage[country] = new Dictionary<string, object>();
                        Dictionary<string, object>list = new Dictionary<string, object>();
                        var l = new HashSet<string>();
                        l.Add(player);
                        list["names"] = l;
                        list["wins"] = 1;
                        storage[country] = list;
                    }
                    else
                    {
                        var m = storage[country];
                        var n = m["names"];
                        List<object> myAnythingList = (n as IEnumerable<object>).Cast<object>().ToList();
                        myAnythingList.Add(player);
                        storage[country]["names"] = myAnythingList;
                        var w = (int)storage[country]["wins"]+1;
                        storage[country]["wins"] = w;
                    }   
            }
        }
       storage = storage.OrderByDescending(x => x.Value["wins"])
           .ToDictionary(x => x.Key, x => x.Value);
        foreach (var pair in storage)
        {
            var key = pair.Key;
            var value = pair.Value;
            int num = 0;
            int participants = 0;
            foreach (var item in value)
            {
                var k = item.Key;
                var v = item.Value;
                if (k=="wins")
                {
                     num = (int)item.Value;
                }
                else
                {
                    HashSet<string> orderedSet = new HashSet<string>();
                    List<object> myList = (item.Value as IEnumerable<object>).Cast<object>().ToList();
                    foreach (var i in myList)
                    {
                        orderedSet.Add(i.ToString());
                    }
                    participants = orderedSet.Count;
                }
            }
                Console.WriteLine("{0} ({1} participants): {2} wins", key, participants, num);
            
        }
  
    }
}

