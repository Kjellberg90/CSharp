using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurpark
{
    class Zoo 
    {
        private List<string> _animalList;
        private enum _foodtype{ }; //Fastnat här

        public Zoo()
        {
            _animalList = new List<string>() { "Lion", "Zebra" , "Zebra", "Lion", "Zebra" };
        }

        public void FeedAllAnimals(string food)
        {
            for (int i = 0; i < _animalList.Count; i++)
            {
                Animal.Feed(food);
            }
        }
    }
}
