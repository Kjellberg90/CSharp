using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileExplorer
{
    class ConsoleExplorer
    {

        private int currentIndex;
        public void Run()
        {
            string[] directoryArray = Directory.GetFileSystemEntries(".");
            for (int i = 0; i < directoryArray.Length; i++)
            {
                if (File.Exists(directoryArray[i]))
                {
                    Console.WriteLine($"- {Path.GetFileName(directoryArray[i])}");
                }
                else
                {
                Console.WriteLine($"# {Path.GetFileName(directoryArray[i])}");
                }
            }
            while (true)
            {
                
                
            }
        }
    }
}
