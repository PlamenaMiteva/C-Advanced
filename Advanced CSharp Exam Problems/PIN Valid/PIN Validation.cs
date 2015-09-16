using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PINValidation
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split(' ');
        if (names.Length != 2 || char.IsLower(names[0][0]) || char.IsLower(names[1][0]))
        {
            Console.WriteLine("<h2>Incorrect data</h2>");
        }
        else
        {
            string gender = Console.ReadLine();
            string pin = Console.ReadLine();
            if (pin.Length != 10)
            {
                Console.WriteLine("<h2>Incorrect data</h2>");
            }
            else
            {
                int[] numbers = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
                string date = pin.Substring(0, 6);
                int month = int.Parse(date.Substring(2, 2));
                int day = int.Parse(date.Substring(4));
                int genderNum = int.Parse(pin.Substring(8, 1));
                if (month > 52 || month == 0 || day == 0 || day > 31 || pin.Length != 10)
                {
                    Console.WriteLine("<h2>Incorrect data</h2>");
                }
                else if ((genderNum % 2 != 0 && gender == "male") || (genderNum % 2 == 0 && gender == "female"))
                {
                    Console.WriteLine("<h2>Incorrect data</h2>");
                }
                else
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sum += numbers[i] * int.Parse(pin[i].ToString());
                    }
                    int checksum = (int)(sum % 11);
                    if (checksum == 10)
                    {
                        checksum = 0;
                    }
                    if (checksum != int.Parse(pin.Substring(9)))
                    {
                        Console.WriteLine("<h2>Incorrect data</h2>");
                    }
                    else
                    {
                        Console.WriteLine("{\"name\":\"" + string.Join(" ", names) + "\",\"gender\":\"" + gender + "\",\"pin\":\"" + pin + "\"}");
                    }
                }
            }
        }
    }
}

