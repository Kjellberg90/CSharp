using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesSerialize
{


    class PersonDeserializer
    {
        private readonly string _directoryPath;

        public PersonDeserializer()
        {
            _directoryPath = @"E:\SKY\CSharp\Eget Arbete\FilesSerialize\Persons";
        }

        public List<Person> ReadFromSingleFile(string fileName)
        {
            List<Person> personList = new List<Person>();
            var fileLenght = File.ReadAllLines(_directoryPath + "//" + fileName).Length;

            using (StreamReader sr = new StreamReader(_directoryPath + "//" + fileName))
            {
                for (int i = 0; i < fileLenght; i++)
                {
                    var newPerson = sr.ReadLine().Split(",");
                    personList.Add(new Person() { Id = Convert.ToInt32(newPerson[0]), Name = newPerson[1], Age = Convert.ToInt32(newPerson[2]) });
                }
            }
            return personList;
        }

        public List<Person> ReadFromMultipleFiles()
        {
            List<Person> personList = new List<Person>();
            string[] files = Directory.GetFiles(_directoryPath);

            for (int i = 0; i < files.Length; i++)
            {
                {
                    string fileName = Path.GetFileName(files[i]);


                    if (fileName.StartsWith("persons_"))
                    {
                        var fileLenght = File.ReadAllLines(_directoryPath + "//" + fileName).Length;
                        using (StreamReader sr = new StreamReader(_directoryPath + "//" + fileName))
                        {

                            string id = sr.ReadLine();
                            string name = sr.ReadLine();
                            string age = sr.ReadLine();

                            var Person = new Person()
                            {
                                Id = Convert.ToInt32(id),
                                Name = name,
                                Age = Convert.ToInt32(age)
                            };
                            personList.Add(Person);
                        }
                    }
                }
            }
            return personList;
        }
    }
}

