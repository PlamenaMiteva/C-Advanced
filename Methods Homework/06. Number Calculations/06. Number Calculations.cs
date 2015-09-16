using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberCalculations
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split(' ').Select(n => Double.Parse(n)).ToArray();
        Console.WriteLine("min number: " + GetMinNumber(numbers));
        Console.WriteLine("max number: " + GetMaxNumber(numbers));
        Console.WriteLine("avg: " + GetAvgNumber(numbers));
        Console.WriteLine("sum: " + GetSum(numbers));
        Console.WriteLine("product: " + GetProduct(numbers));
        Console.ReadLine();
    }
    static double GetMinNumber(double[] numbers)
    {
        double min = double.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }
    static double GetMaxNumber(double[] numbers)
    {
        double max = double.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static double GetAvgNumber(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum / numbers.Length;
    }
    static double GetSum(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static double GetProduct(double[] numbers)
    {
        double product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product*= numbers[i];
        }
        return product;
    }
}

