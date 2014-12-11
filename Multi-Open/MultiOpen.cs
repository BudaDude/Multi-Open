using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Multi_Open
{
    class MultiOpen
    {
        
        public void OpenFiles()
        {
            try
            {

                string[] lines = File.ReadAllLines("programs.txt");
                foreach (string path in lines)
                {
                    Console.WriteLine(path);
                    Process.Start(path);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Couldn't open the file. Is the text file in the same dictionary? ");
                Console.WriteLine(e.Message);
            }

        }
    }
}
