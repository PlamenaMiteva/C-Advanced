using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("somefile.txt");
            using (reader)
            {
                int lineNumber = -1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber+=2;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
            reader.Close();
            Console.ReadLine();
        }
    }

