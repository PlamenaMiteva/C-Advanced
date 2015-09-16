using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Longest_Increasing_Sequence
{
    class LongestIncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int num = items[0];
            int sequenceLenght = 0;
            int maxLength = 0;
            string longestSequence = "";
            bool isLastItem = false;
            for (int i = 0; i < items.Length; i++)
            {
                if (isLastItem)
                {
                    break;  
                }
                Console.Write(num + " ");
                sequenceLenght++;
                string sequence = num+" ";
                for (int j = i + 1; j < items.Length; j++)
                {
                    int secNum = items[j];
                    if (secNum>num)
                    {
                        Console.Write(secNum+" ");
                        num = secNum;
                        sequenceLenght++;
                        sequence += items[j]+" ";
                        if (num==items[items.Length-1])
                        {
                            isLastItem = true;
                        }
                        
                    }
                    else
                    {
                        i = j-1;
                        num = items[j];
                        break;
                    }
                    
                }
                if (sequenceLenght > maxLength)
                {
                    maxLength = sequenceLenght;
                    longestSequence = sequence;
                }
                Console.WriteLine();
                sequenceLenght = 0;
            }
            Console.WriteLine("Longest: "+longestSequence);
            Console.ReadLine();
        }
    }
}
