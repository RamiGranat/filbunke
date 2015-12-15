using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Fruit : IComparable<Fruit>
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public Fruit(string name, int number)
        {
            Name = name;
            Number = number;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Number: {Number}";
        }

        public int CompareTo(Fruit other)
        {
            return Number.CompareTo(other.Number);
        }
    }
}
