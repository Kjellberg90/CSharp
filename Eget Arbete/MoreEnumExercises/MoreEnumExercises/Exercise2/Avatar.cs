using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreEnumExercises.Exercise2
{
    class Avatar
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public string CurrentPosition
        {
            get
            {
                return $"({X}, {Y})";
            }
        }

        public Avatar()
        {
            X = 50;
            Y = 50;
        }

        public void Move(ConsoleKey direction)
        {
            switch (direction)
            {
                case ConsoleKey.W:
                    Y--;
                    break;
                case ConsoleKey.A:
                    X++;
                    break;
                case ConsoleKey.S:
                    Y++;
                    break;
                case ConsoleKey.D:
                    X--;
                    break;
                default:
                    Console.WriteLine("I don't know about that direction");
                    break;
            }
        }
    }
}
