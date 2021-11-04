using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileExplorer
{
    internal class FolderView
    {

        public void printList(int currentIndex)
        {
            Console.Clear();
            string[] directoryArray = Directory.GetFileSystemEntries(".");
            for (int i = 0; i < directoryArray.Length; i++)
            {
                if (currentIndex == i)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }

                if (File.Exists(directoryArray[i]))
                {
                    Console.WriteLine($"- {Path.GetFileName(directoryArray[i])}");
                }
                else
                {
                    Console.WriteLine($"# {Path.GetFileName(directoryArray[i])}");
                }
            }
        }

        public int Up(ConsoleKey input, int currentIndex)
        {
            string[] directoryArray = Directory.GetFileSystemEntries(".");
            if (input == ConsoleKey.W)
            {
                currentIndex--;
                if (currentIndex < 0)
                {
                    currentIndex = 0;
                }
            }
            return currentIndex;
        }

        public int Down(ConsoleKey input, int currentIndex)
        {
            string[] directoryArray = Directory.GetFileSystemEntries(".");
            if (input == ConsoleKey.S)
            {
                currentIndex++;
                if (currentIndex >= directoryArray.Length)
                {
                    currentIndex = directoryArray.Length - 1;
                }
            }
            return currentIndex;
        }

    }
}
