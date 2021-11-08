using System;
using System.Collections.Generic;

namespace Exam
{
    class Create
    {
        public Car CreateOneCar()
        {
            string regNumber = Console.ReadLine();
            string age = Console.ReadLine();
            int ageInt= Convert.ToInt32(age);

            if (ageInt < 0 || ageInt > 50)
            {
                Console.WriteLine("Invalid Age");
                return null;
            }

            return new Car(regNumber,age);
        }

        public List<Car> CreateThreeCars()
        {
            List<Car> carList = new List<Car>();
            for (int i = 0; i < 3; i++)
            {
                string regNumber = Console.ReadLine();
                string age = Console.ReadLine();
                carList.Add(new Car(regNumber, age));
            }
            return carList;
        }
    }
}
