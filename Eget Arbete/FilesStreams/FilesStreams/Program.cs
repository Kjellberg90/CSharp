using System;

namespace FilesStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFileHandler fileHandler = new MyFileHandler();
            fileHandler.ReadAllContent();
            fileHandler.WriteContentToFile();
            fileHandler.UpperCaseContent("testfile2.txt", "testfile2toupper.txt");
            fileHandler.ReadLatinEncodedContent();
        }
    }
}
