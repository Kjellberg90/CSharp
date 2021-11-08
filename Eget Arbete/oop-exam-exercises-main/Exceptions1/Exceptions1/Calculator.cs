using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions1
{
    class Calculator
    {
        public void ComputeAverage()
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a number or press enter to compute the average.");
                    string input = Console.ReadLine();

                    if (input == "")
                    {
                        break;
                    }

                    numbers.Add(Convert.ToInt32(input));

                }
                catch (FormatException)
                {
                    Console.WriteLine("Ogiltig värde, försk igen");
                }
            }

            // Input done, now compute average
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("The Average is: 0");
            }
            else
            {
                double average = sum / numbers.Count;
                Console.WriteLine($"The average is: {average}");
            }
        }
    }
}
