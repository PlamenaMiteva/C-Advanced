using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ReverseNumber
    {
        static void Main()
        {
            string number=Console.ReadLine();
            double reversed = Double.Parse(GetReversedNumber(number));
            Console.WriteLine(reversed);
            Console.ReadLine();
        }
        static string GetReversedNumber(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }

