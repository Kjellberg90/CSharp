using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion7
{
    class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public int SetAge()
        {
            if (_age > 100)
            {
                _age = 100;
            } 
            else if (_age < 0)
            {
                _age = 0;
            }
            else
            {
            _age = _age;
            }
        }
    }

    class Account
    {
        public double _value;

        public Account(double value)
        {
            _value = value;
            Console.WriteLine(_value);
        }
    }

    class Product
    {
        private int _productAge;
        public Product(int productAge)
        {
            _productAge = productAge;
            Console.WriteLine(_productAge);
        }

        public Product() : this(0)
        {
            Console.WriteLine(_productAge);
        }
    }

    class Bicycle
    {
        public int _age;
        public int _gear;

        public Bicycle(int age, int gear)
        {
            _age = age;
            _gear = gear;
            Console.WriteLine($"Alder: {_age} Växel: {_gear}");
        }

        public Bicycle(int age) : this()
        {
            _age = age;
            _gear = 1;
            Console.WriteLine($"Alder: {_age} Växel: {_gear}");
        }

        public Bicycle()
        {
            _age = 0;
            _gear = 0;
            Console.WriteLine($"Alder: {_age} Växel: {_gear}");
        }
    }

    class Movie // Lite osäker på vad som menas
    {
        public string _title;
        public int _watchNumber;

        public Movie(string title)
        {
            _title = title;
            _watchNumber = 5;
        }

        public void Personseenmovie()
        {
            _watchNumber++;
        }

        public string DescribeMovie()
        {
            return $"The Movie is  called {_title} and has been seen by {_watchNumber} people";
        }
    }

    class Additor
    {
        public int _int1;
        public int _int2;

        public Additor(int int1, int int2)
        {
            _int1 = int1;
            _int2 = int2;
        }

        public int Add()
        {
            return _int1 + _int2;
        }
    }

    class Subtractor
    {
        public int Compute(int x, int y)
        {
            return x - y;
        }
    }
}


