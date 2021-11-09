using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Skriv in ett nummer");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input <= 100 && input >= -200)
                {
                    for (int i = input; i < 100; i++)
                    {
                        Console.WriteLine(++input);
                    }
                }
                else if (input <= -200)
                {
                    Console.WriteLine("Skriv ett nummer större än eller lika med -200");
                }
                else if (input >= 100 && input <= 200)
                {
                    for (int i = input; i > 100; i--)
                    {
                        Console.WriteLine(--input);
                    }
                }
                else
                {
                    Console.WriteLine("Skriv ett nummer mindre än eller lika med 200");
                }
            }

        }
    }
}
