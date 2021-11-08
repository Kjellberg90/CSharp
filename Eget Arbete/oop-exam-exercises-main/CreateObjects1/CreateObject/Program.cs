using System;
using Exam;


namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Create create = new Create();

            var x = create.CreateOneCar();

            Console.WriteLine(x);

            var y = create.CreateThreeCars();

            for (int i = 0; i < y.Count; i++)
            {
                Console.WriteLine(y);
            }
        }
    }
}
