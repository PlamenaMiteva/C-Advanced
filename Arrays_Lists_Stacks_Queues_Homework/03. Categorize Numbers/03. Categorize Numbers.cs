using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Categorize_Numbers
{
    class CategorizeNumbers
    {
        static void Main(string[] args)
        {  
            string[] items = Console.ReadLine().Split(' ');
            List<int> intList = new List<int>();
            List<double> doubleList = new List<double>();
            for (int i = 0; i < items.Length; i++)
            {
                double num = double.Parse(items[i]);
                if (num % 1 == 0)
                {
                    int number = (int)num;
                    intList.Add(number);
                }
                else
                {
                    doubleList.Add(num);
                }
            }
            Console.Write("[");
            for (int a = 0; a < doubleList.Count; a++)
            {
                if (a == doubleList.Count - 1)
                {
                    Console.Write(doubleList[a].ToString("F"));
                }
                else
                {
                    Console.Write(doubleList[a].ToString("F") + ", ");
                }
            }
            Console.WriteLine("] -> min: " + doubleList.Min().ToString("F") + ", max: " + doubleList.Max().ToString("F") + ", sum: " + doubleList.Sum().ToString("F") + ", avg: " + doubleList.Average().ToString("F"));
            Console.Write("[");
            for (int b = 0; b < intList.Count; b++)
            {
                if (b == intList.Count - 1)
                {
                    Console.Write(intList[b]);
                }
                else
                {
                    Console.Write(intList[b] + ", ");
                }
            }
            Console.WriteLine("] -> min: " + intList.Min() + ", max: " + intList.Max() + ", sum: " + intList.Sum() + ", avg: " + intList.Average().ToString("F"));           
            Console.ReadLine();
        }

    }
}
