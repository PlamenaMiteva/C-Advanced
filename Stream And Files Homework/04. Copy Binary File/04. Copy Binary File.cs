using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CopyBinaryFile
    {
        static void Main()
        {
            using (FileStream stream = File.OpenRead("image.jpg"))
            using (FileStream writeStream = File.OpenWrite("newimage.jpg"))
            {
                BinaryReader reader = new BinaryReader(stream);
                BinaryWriter writer = new BinaryWriter(writeStream);

                // create a buffer to hold the bytes 
                byte[] buffer = new Byte[1024];
                int bytesRead;

                // while the read method returns bytes
                // keep writing them to the output stream
                while ((bytesRead =
                        stream.Read(buffer, 0, 1024)) > 0)
                {
                    writeStream.Write(buffer, 0, bytesRead);
                }
            }
    }
}


        
    

