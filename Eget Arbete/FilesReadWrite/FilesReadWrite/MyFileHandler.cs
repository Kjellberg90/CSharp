using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesReadWrite
{
    class MyFileHandler
    {
        public void ReadAllContent()
        {
            string myString = File.ReadAllText("testfile1.txt");
            Console.WriteLine(myString);
        }

        public void WriteContentToFile(string myNewString)
        {
            File.WriteAllText("myNewFile", myNewString);
        }

        public void UpperCaseContent(string file1, string file2)
        {
            string textFile1 = File.ReadAllText($"{file1}");

            string newString = textFile1.ToUpper();

            File.WriteAllText($"{file2}", newString);
        }

        public void ReadLatinEncodedContent()
        {
            string myString = File.ReadAllText("latin1.txt", Encoding.Latin1 );
            Console.WriteLine(myString);
        }
    }
}
