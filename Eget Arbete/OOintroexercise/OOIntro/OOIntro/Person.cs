using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOIntro
{
    class Person
    {
        public int Speed { get; set; }

        public Backpack Backpack { get; set; }

        public Person()
        {
            Backpack = new Backpack();
            Speed = 10;
        }

        public Person(Backpack backpack)
        {
            Backpack = backpack;
            Speed = 10;
        }

        public void Run()
        {
            Console.WriteLine($"The person runs at {Speed} km/h");
        }

        public void LookInBag()
        {
            Console.WriteLine($"The person looks in the {Backpack.BackpackBrand} and sees");
            Console.WriteLine($"and sees");
            for (int i = 0; i < Backpack.Snacks.Length; i++)
            {
                Console.WriteLine(Backpack.Snacks[i]);
            }
        }

        public void eat()
        { 
            Random rand = new Random(); 
            int index = rand.Next(Backpack.Snacks.Length); 
            Console.WriteLine($"The person takes a bite of the {Backpack.Snacks[index]} and wanders on");
        }
    }
}
