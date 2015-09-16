using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _06.Subset_Sums
{
    class SubsetSums
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            string[] array = input.Distinct().ToArray();
            int count = 1 << array.Length; // 2^n
            int matches = 0;
            for (int i = 0; i < count; i++)
            {
                string[] items = new string[array.Length];
                BitArray b = new BitArray(BitConverter.GetBytes(i));
                string result = "";
                for (int bit = 0; bit < array.Length; bit++)
                {
                    items[bit] = b[bit] ? array[bit] + "+" : "";
                    result = result+items[bit];
                }
                    if (result != "")
                    {
                        string[] nums = result.Split('+').ToArray();
                        int sum=0;
                        int counter = 0;
                        for (int j = 0; j < nums.Length; j++)
                        {
                            if (nums[j]!=""&&nums[j]!=" ")
                            {
                                int n = Int32.Parse(nums[j]);
                                sum += n;
                                counter++;
                            }
                        }
                        if (sum==number && counter>0)
                        {
                            Console.WriteLine(result.Substring(0, result.Length-1));
                            matches++;
                        }
                        counter = 0;
                    }
                
                //Console.WriteLine(String.Join("", items));
            }
            if (matches==0)
            {
                Console.WriteLine("No matching subsets."); 
            }
            Console.ReadLine();
        }
    }
}
