using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesSerialize
{
    class Data
    {
        public static List<Person> People { get; } = new List<Person>()
        {
            new Person() { Id = 100, Name = "Adam", Age = 12 },
            new Person() { Id = 200, Name = "Olle", Age = 33 },
            new Person() { Id = 300, Name = "Berit", Age = 44 },
        };
    }
}
