using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Larger_Than_Neigbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }
            Console.ReadLine();
        }
        static bool IsLargerThanNeighbours(int[] numbers, int position)
        {
            bool result = true;
            if (position == 0)
            {
                if (numbers[position] > numbers[position + 1])
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else if (position == numbers.Length-1)
            {
                if (numbers[position] > numbers[position - 1])
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                if (numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1])
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;

        }
    }
}
