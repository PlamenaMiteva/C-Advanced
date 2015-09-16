using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sequences_Of_Equal_Strings
{
    class SequencesOfEqualStrings
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(' ');
            List<string> uniqueItems = new List<string>();
           uniqueItems.AddRange(items.Distinct());
           for (int i = 0; i < uniqueItems.Count; i++)
           {
               string word = uniqueItems[i];
               for (int j = 0; j < items.Length; j++)
               {
                   string secWord = items[j];
                   if (secWord == word)
                   {
                       Console.Write(word+" ");
                   }
               }
               Console.WriteLine();
           }
           Console.ReadLine();
        }
    }
}
