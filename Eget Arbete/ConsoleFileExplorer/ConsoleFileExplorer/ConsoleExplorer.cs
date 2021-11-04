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
            FolderView folderView = new FolderView();
            while (true)
            {
                folderView.printList(currentIndex);

                var input = Console.ReadKey().Key;
                if (input == ConsoleKey.W)
                {
                    currentIndex = folderView.Up(input, currentIndex);
                }
                if (input == ConsoleKey.S)
                {
                    currentIndex = folderView.Down(input, currentIndex);
                }
            }
        }
    }
}
