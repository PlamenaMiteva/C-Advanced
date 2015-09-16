using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class VladkosNotebook
{
    static void Main()
    {
        SortedDictionary<string, Dictionary<string, object>> storage = new SortedDictionary<string, Dictionary<string, object>>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            else
            {
                string[] str = input.Split('|').ToArray();
                string color = str[0];
                string key = str[1];
                string value = str[2];
                if (!storage.ContainsKey(color))
                {
                    Dictionary<string, object> temp = new Dictionary<string, object>();
                    if (key == "name" || key == "age")
                    {
                        temp[key] = value;
                        storage[color] = temp;
                    }
                    else
                    {
                        var opp = new List<string>();
                        opp.Add(value);
                        temp["opponents"] = opp;
                        storage[color] = temp;
                        if (key == "win")
                        {
                            storage[color][key] = 1;
                        }
                        if (key == "loss")
                        {
                            storage[color][key] = 1;
                        }
                    }
                }
                else
                {
                    var temporary = storage[color];
                    if (key == "name" || key == "age")
                    {
                        storage[color][key] = value;
                    }
                    else
                    {
                        if (!storage[color].ContainsKey("opponents"))
                        {
                            List<string> enemies = new List<string>();
                            enemies.Add(value);
                            storage[color]["opponents"] = enemies;
                        }
                        else
                        {
                            var enemy = storage[color]["opponents"];
                            List<object> myAnythingList = (enemy as IEnumerable<object>).Cast<object>().ToList();
                            myAnythingList.Add(value);
                            storage[color]["opponents"] = myAnythingList;
                        }
                        if (key == "win")
                        {
                            if (storage[color].ContainsKey(key))
                            {
                                int a = (int)storage[color][key];
                            storage[color][key] = a+1;
                            }
                            else
                            {
                                storage[color][key] = 1;
                            }
                            
                        }
                        if (key == "loss")
                        {
                            if (storage[color].ContainsKey(key))
                            {
                                int a = (int)storage[color][key];
                                storage[color][key] = a + 1;
                            }
                            else
                            {
                                storage[color][key] = 1;
                            }
                        }
                    }
                }
            }
        } 
        int count = 0;
        foreach (var pair in storage)
        {
            var color = pair.Key;
            var obj = pair.Value;
            if (obj.ContainsKey("name") && obj.ContainsKey("age"))
            {
                count++;
                double wins = 0;
                double losses = 0;
                int counter = 0;
                Console.WriteLine("Color: " + color);
                foreach (var coppia in obj)
                {
                    if (coppia.Key == "age")
                    {
                        Console.WriteLine("-age: " + coppia.Value);
                    }
                }
                foreach (var coppia in obj)
                {
                    if (coppia.Key == "name")
                    {
                        Console.WriteLine("-name: " + coppia.Value);
                    }
                }
                foreach (var coppia in obj)
                {
                    if (coppia.Key == "opponents")
                    {
                        var list = coppia.Value;
                        List<object> myList = (list as IEnumerable<object>).Cast<object>().ToList();
                        List<string> strings = myList.Select(s => (string)s).ToList();
                        string[] final = strings.ToArray();
                        Array.Sort(final, StringComparer.Ordinal);                        
                        Console.WriteLine("-opponents: " + string.Join(", ", final));
                        counter++;

                    }
                }
                foreach (var coppia in obj)
                {
                    if (coppia.Key == "win")
                    {
                        wins = (int)coppia.Value;
                    }
                    if (coppia.Key == "loss")
                    {
                        losses = (int)coppia.Value;
                    }

                }
                if (counter == 0)
                {
                    Console.WriteLine("-opponents: (empty)");
                }
                double rank = (wins + 1) / (losses + 1);
                Console.WriteLine("-rank: {0:N2}", rank);
            }
        }
            if (count==0)
            {
                Console.WriteLine("No data recovered.");
            }
    }
}


