using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabrikenRobin
{
    class Factory
    {
        public List<Product> productList;

        public Factory()
        {
            productList = new List<Product>();
            productList.Add(new Rubberduck());
            productList.Add(new Car());
        }

        public void Listcomparison(List<Material> m1)
        {
            foreach (var item in productList)
            {
                foreach (var material in m1)
                {

                    if (item.ritning.SequenceEqual(m1)) //item.ritning.Contains(material))
                    {
                        Console.WriteLine("Rubberduck");
                    }
                    Console.WriteLine(item.ritning[0]);
                    Console.WriteLine(item.ritning[1]);
                    Console.WriteLine(m1[0]);
                    Console.WriteLine(m1[1]);
                }
            }
        }
    }
}
