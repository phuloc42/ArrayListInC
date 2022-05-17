using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListInC
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {
            return "Name:" + name + "Age:" + age;
        }
    }
}
