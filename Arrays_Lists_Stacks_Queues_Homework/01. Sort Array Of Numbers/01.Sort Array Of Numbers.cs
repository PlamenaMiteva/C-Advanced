using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main()
        {
            string inputArray = Console.ReadLine();
            string[] items = inputArray.Split(' ');
            int[] arr = new int[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = int.Parse(items[i]); 
            }
            Array.Sort(arr);
            arr.ToList().ForEach(num => Console.WriteLine(num));

        }
    }
}
    

