using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Square : Shape
    {
        public double Side { get; set; }
        public Square() { }
        public Square(string name, double side) : base(name)
        {
            Side = side;
        }
        public override double Area()
        {
            double area = Side * Side;
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = 4 * Side;
            return perimeter;
        }
    }
}
