using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle() { }
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double Area()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = 2 * Math.PI * Radius;
            return perimeter;
        }
    }
}
