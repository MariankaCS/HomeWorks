using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    abstract class Shape : IComparable<Shape>
    {
        public string Name { get; set; }

        public Shape() { }

        public Shape(string name)
        {
            Name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(Shape obj)
        {
            return this.Area().CompareTo(obj.Area());
        }

    }
}
