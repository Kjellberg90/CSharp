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
        private ViewState _viewState;
        private int currentIndex;

        public void Run()
        {
            FolderView folderView = new FolderView();
            while (true)
            {
                if (_viewState == ViewState.List)
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
                    if (input == ConsoleKey.Enter)
                    {
                        _viewState = ViewState.FileView;
                    }
                }
                if (_viewState == ViewState.FileView)
                {
                    Console.Clear();
                    folderView.ViewFile(currentIndex);
                    Console.WriteLine("------------------------------------------}");
                    Console.WriteLine("Press any key to exit file");
                    Console.ReadKey();
                    _viewState = ViewState.List;
                }
            }
        }
    }
}
