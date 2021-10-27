using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMappings
{
    public class Person
    {
        private static int _idCounter;

        public string Name { get; init; }
        public int Age { get; set; }
        public int Id { get; set; }

        public Person()
        {
            Id = _idCounter++;
        }

    }
}
