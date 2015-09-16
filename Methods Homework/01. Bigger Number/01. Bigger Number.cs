using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Homework
{
    class BiggerNumber
    {
        static void Main()
        {
            int firstNumber = Int32.Parse(Console.ReadLine());
            int secondNumber = Int32.Parse(Console.ReadLine());
            if (firstNumber == secondNumber)
            {
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                int max = GetMax(firstNumber, secondNumber);
                Console.WriteLine(max);
                Console.ReadLine();
            }
        }
        static int GetMax(int first, int second)
        {
            return first > second ? first : second;
        }
    }
}
