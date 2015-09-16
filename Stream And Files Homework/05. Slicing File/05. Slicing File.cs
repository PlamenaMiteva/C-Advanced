using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SlicingFile
{
    static void Main()
    {
        string file= "Game Of Thrones.avi";
        SplitFile(file, "", 5);
    }
    public static void SplitFile(string sourceFile, string destinationDirectory, int parts)
    {
        FileStream fs = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
        int sizeOfEachFile = (int)Math.Ceiling((double)fs.Length / parts);
        for (int i = 1; i <= parts; i++)
        {
            string baseFileName = Path.GetFileNameWithoutExtension(sourceFile);
            string extension = Path.GetExtension(sourceFile);
            FileStream outputFile = new FileStream(destinationDirectory + "\\"+baseFileName + "." + i.ToString().PadLeft(5, Convert.ToChar("0")) + extension, FileMode.Create, FileAccess.Write);
            int bytesRead = 0;
            byte[] buffer = new byte[sizeOfEachFile];

            if ((bytesRead = fs.Read(buffer, 0, sizeOfEachFile)) > 0)
            {
                outputFile.Write(buffer, 0, bytesRead);
            }
            outputFile.Close();
        }
        fs.Close();
    }
    public static void Assemble(List<string> files, string destinationDirectory)
    {
        int numberOfFiles = files.Count;       
        using ( FileStream outputFile = new FileStream(destinationDirectory + "\\" + "outputFile.avi", FileMode.Create, FileAccess.Write))
        {
            foreach (string file in files)
            {
                using (var sourceStream = File.OpenRead(file))
                    sourceStream.CopyTo(outputFile);                 
            }
        }
    }
}


