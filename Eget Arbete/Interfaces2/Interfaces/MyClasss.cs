using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class MyClasss : IOutputProvider, IInputGatherer
    {
        static List<int> myInt = new List<int>();
        string myString = "";

        public void CollectInput(int value)
        {
            myInt.Add(value);
        }

        public string GetOutput()
        {
            string newString = "";
            myInt.Sort();
            myInt.Reverse();
            for (int i = 0; i < myInt.Count; i++)
            {
                newString += myInt[i] + "\n";
            }
            return newString;
        }
    }
}
