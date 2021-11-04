using System;

namespace FilesSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonSerializer personSerializer = new PersonSerializer();

            personSerializer.SerializeInOneFile(Data.People);
            personSerializer.SerializeInManyFiles(Data.People);


            PersonDeserializer personDeserializer = new PersonDeserializer();
            var x = personDeserializer.ReadFromSingleFile("persons.txt");

            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine($"{x[i].Id}, {x[i].Name}, {x[i].Age}");
            }

            var z = personDeserializer.ReadFromMultipleFiles();

            for (int i = 0; i < z.Count; i++)
            {
                Console.WriteLine($"{z[i].Id}, {z[i].Name}, {z[i].Age}");
            }
        }
    }
}
