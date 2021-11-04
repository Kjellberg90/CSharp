using System;
using System.IO;
using System.Text;
using System.Threading;

namespace FilesReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFileHandler myFileHandler = new MyFileHandler();

            //myFileHandler.ReadAllContent();

            myFileHandler.WriteContentToFile("String from C Sharp");

            myFileHandler.UpperCaseContent("myNewFile.txt", "ToUpperFile.txt");

            myFileHandler.ReadLatinEncodedContent();

            NoteBook noteBook = new NoteBook();


            while (true)
            {
                Console.WriteLine("Enter new note:");
                var input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }
                noteBook.TakeNote(input);
                noteBook.GetAllNotes();
                Thread.Sleep(5000);
                Console.Clear();
            }
        }
    }
}