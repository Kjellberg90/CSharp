using System;
using System.IO;
using System.Text;

namespace FilesStreams
{
    class MyFileHandler
    {
        private readonly string file = "testfile1.txt";
        private readonly string file2 = "testfile2.txt";
        private readonly string file3 = "latin1.txt";
        public void ReadAllContent()
        {
            FileStream fs = File.OpenRead(file);
            StreamReader sr = new StreamReader(fs);
            try
            {
                Console.WriteLine(sr.ReadLine());
                Console.WriteLine(sr.ReadLine());
            }
            finally
            {
                sr.Close();
            }
        }

        public void WriteContentToFile()
        {
            FileStream fs = File.OpenWrite(file2);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("Some text on row 1");
                sw.WriteLine("Some text on row 2");
                sw.WriteLine("Some text on row 3");
            }
        }

        public void UpperCaseContent(string file1, string file2)
        {
            FileStream fs1 = File.OpenRead(file1);
            using (StreamReader sr = new StreamReader(fs1))
            {
                FileStream fs2 = File.OpenWrite(file2);
                using (StreamWriter sw = new StreamWriter(fs2))
                {
                    while (true)
                    {
                        string line = sr.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        else
                        {
                            sw.WriteLine(line.ToUpper());
                        }
                    }
                }
            }
        }

        public void ReadLatinEncodedContent()
        {
            FileStream fs = File.OpenRead(file3);
            using (StreamReader sr = new StreamReader(fs))
            {
                string myString = sr.ReadLine(); 
                byte[] bytes = Encoding.Latin1.GetBytes(myString);
                foreach (byte b in bytes)
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
