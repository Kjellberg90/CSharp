using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOIntro
{
    class Person
    {
        public int Speed { get; set; } = 10;

        public Backpack MyBackPack { get; set;}

        public Person()
        {
            MyBackPack = new Backpack();
        }

        public Person(string brand)
        {
            MyBackPack = new Backpack(brand);    
        }

        public void Run()
        {
            Console.WriteLine($"The person runs at {Speed} km/h");
        }

        public void LookInBag()
        {
            Console.WriteLine();
            Console.WriteLine($"The Person look in the {MyBackPack.BackpackBrand} bag and sees the following items:");
            for (int i = 0; i < MyBackPack.Snacks.Length ; i++)
            {
                Console.WriteLine($"{i + 1}: {MyBackPack.Snacks[i]}");
            }
        }

        public void Eat()
        {
            Console.WriteLine();
            Random random = new Random();
            int rand = random.Next(MyBackPack.Snacks.Length);
            Console.WriteLine($"The Person takes out and eats the: {MyBackPack.Snacks[rand]}");

        }
    }
}
