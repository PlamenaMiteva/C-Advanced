using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


    class BiggestTableRow
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            double biggestSum = double.MinValue;
            string max = "";
            while (true)
            {
                 string tableRow = Console.ReadLine();
                 if (tableRow=="</table>")
                 {
                     break;
                 }
                 else
                 {
                     double sum = 0;
                     Regex rx = new Regex(@"-?\d+\.?,?\d*");
                     MatchCollection matches = rx.Matches(tableRow);
                     string str = "";
                     foreach (Match match in matches)
                     {
                         sum += double.Parse(match.ToString());
                         str += match.ToString() + " + ";

                     }
                         if (sum>biggestSum)
                         {
                             biggestSum = sum; 
                             max =str;
                         }
                     
                 }
            }
            if (max == "")
            {
                Console.WriteLine("no data");
            }
            else
            {
                Console.WriteLine("{0} = " + max.Substring(0, max.Length - 3), biggestSum);
            }
        }
    }

