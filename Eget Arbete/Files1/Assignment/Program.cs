using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader sr = new StreamReader(@"C:\Users\danie\Desktop\Files1\Assignment" + "\\" + "books.txt"))
            {
                List<Book> book = new List<Book>();
                while (!sr.EndOfStream)
                {
                    string[] Line = sr.ReadLine().Split("§");

                    book.Add(new Book() { Author = Line[1], Title = Line[0], Genre = Line[2] });
                }

                

                for (int i = 0; i < book.Count; i++)
                {
                    string shorterString = book[i].Title;
                    if (book[i].Title.Length > 30)
                    {
                        shorterString = book[i].Title.Substring(0, 29);
                    }
                    Console.WriteLine($"{shorterString, -30} {book[i].Author, -30} {book[i].Genre}");
                }
            }
        }
    }
}