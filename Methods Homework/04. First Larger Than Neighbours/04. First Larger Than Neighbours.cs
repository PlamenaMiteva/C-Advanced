using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.First_Larger_Than_Neighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(numbers));
            Console.ReadLine();
        }
        static int GetIndexOfFirstElementLargerThanNeighbours(int[] input)
        {
            int index = -1;
            for (int i = 0; i < input.Length; i++)
            {
                if (IsLargerThanNeighbours(input, i) == true)
                {
                    index = i;
                    break;
                }
            }
            return index;
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
            else if (position == numbers.Length - 1)
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
