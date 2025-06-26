using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person other)
        {
            return string.Compare(this.Name, other.Name, StringComparison.CurrentCulture);
        }

        public override bool Equals(object obj)
        {
            if (obj is Person p)
                return Name == p.Name && Age == p.Age;
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }
    }
}
