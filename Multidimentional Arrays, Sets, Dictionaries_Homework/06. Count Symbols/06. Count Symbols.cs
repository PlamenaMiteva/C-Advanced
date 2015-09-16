using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   class CountSymbols
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (char ch in input)
            {
                if (!result.ContainsKey(ch))
                {
                    result[ch] = 1;
                }
                else
                {
                    result[ch]++;
                }
            }
            var list = result.Keys.ToList();
            list.Sort();
            foreach (var key in list)
            {
                if (result[key] == 1)
                {
                    Console.WriteLine("{0}: {1} time", key, result[key]);
                }
                else
                {
                    Console.WriteLine("{0}: {1} times", key, result[key]);
                }
            }
            Console.ReadLine();
        }
    }

