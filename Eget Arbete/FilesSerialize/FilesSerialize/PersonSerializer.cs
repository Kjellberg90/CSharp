using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FilesSerialize
{
    class PersonSerializer
    {
        private readonly string _directoryPath;
        //private List<string> peopleList = new List<string> { };
        private string file = "persons.txt";


        public PersonSerializer()
        {
            _directoryPath = @"E:\SKY\CSharp\Eget Arbete\FilesSerialize\Persons";
        }

        public void SerializeInOneFile(List<Person> person)
        {
            using (StreamWriter sw = new StreamWriter(_directoryPath + "\\" + file))
            {
                string[] personsArray = new string[person.Count];
                for (int i = 0; i < person.Count; i++)
                {
                    personsArray[i] = $"{person[i].Id},{person[i].Name},{person[i].Age}";
                    sw.WriteLine(personsArray[i]);
                }
            }
        }

        public void SerializeInManyFiles(List<Person> person)
        {
            for (int i = 0; i < person.Count; i++)
            {
                file = $"persons_{person[i].Id}.txt";
                using (StreamWriter sw = new StreamWriter(_directoryPath + "\\" + file))
                {
                    sw.WriteLine(person[i].Id);
                    sw.WriteLine(person[i].Name);
                    sw.WriteLine(person[i].Age);
                }
            }
        }
    }
}
