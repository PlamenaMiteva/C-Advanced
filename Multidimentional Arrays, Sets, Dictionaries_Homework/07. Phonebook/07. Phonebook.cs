using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Phonebook
{
    static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        phonebook.Add("Nakov", "+359888001122");
        phonebook.Add("RoYaL(Ivan)", "666");
        phonebook.Add("Gero", "5559393");
        phonebook.Add("Simo", "02/987665544");
        string input = Console.ReadLine();
        if (!phonebook.ContainsKey(input))
        {
            Console.WriteLine("Contact {0} does not exist.", input);

        }
        else
        {
            Console.WriteLine("{0} -> {1}", input, phonebook[input]);
        }
        Console.ReadLine();
    }
}

