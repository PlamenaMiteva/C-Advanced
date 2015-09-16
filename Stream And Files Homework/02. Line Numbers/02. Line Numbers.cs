using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LineNumbers
{
    static void Main()
    {
        using (var reader = new StreamReader("somefile.txt"))
        {
            using (var writer = new StreamWriter("newfile.txt"))
            {
                string line = reader.ReadLine();
                int lineIndex = 0;
                while (line != null)
                {
                    writer.WriteLine(lineIndex+". "+line);
                    line = reader.ReadLine();
                    lineIndex++;
                }
                writer.Close();
            }
            reader.Close();
        }
    }
}

