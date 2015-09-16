using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Last_Digit_Of_Number
{
    class LastDigitOfNumber
    {
        static void Main()
        {
            int inputNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigitAsWord(inputNumber));
            Console.ReadLine();
        }
       static string GetLastDigitAsWord(int number)
        {
            int lastDigit = number % 10;
            string result = "";
            switch (lastDigit)
            {
                case 1: result= "One"; break;
                case 2: result ="Two"; break;
                case 3: result = "Three"; break;
                case 4: result = "Four"; break;
                case 5: result = "Five"; break;
                case 6: result = "Six"; break;
                case 7: result = "Seven"; break;
                case 8: result = "Eight"; break;
                case 9: result = "Nine"; break;
                case 0: result = "Zero"; break;
            }
            return result;
        }
    }
}
