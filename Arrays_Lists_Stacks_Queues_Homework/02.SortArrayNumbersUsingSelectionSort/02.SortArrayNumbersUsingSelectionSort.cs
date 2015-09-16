using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceOfEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' '); //Initialization of String Array from console with divider "space"

            for (int i = 0; i < array.Length - 1; i++)  // logical algorithm (Loop from first index till last but one)
            {
                if (array[i] != array[i + 1])
                {
                    Console.WriteLine(array[i]);
                }
                else
                {
                    Console.Write(array[i] + " ");       //if the sequential indices are identical, they are printed on one linе.
                }

            }

            Console.WriteLine(array[array.Length - 1]);   // Print last index string  



        }

    }
}
