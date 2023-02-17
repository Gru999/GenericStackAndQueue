using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackAndQueue
{
    abstract class Person : IPerson {

        private static int _counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Id = _counter++;
            Name = name;
            Age = age;
        }

        public abstract int CalculateSUPrMonth();

        public override string ToString() {

            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
    }
}
