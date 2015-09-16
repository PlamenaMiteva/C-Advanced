using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class GenericArraySort
    {
        static void Main()
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
            SortItems<int>(numbers);
        }
        static void SortItems<T>(IList<T> input)
        {
            for (int i = 0; i < input.ToArray; i++)
            {
                
            }
        }
    }

