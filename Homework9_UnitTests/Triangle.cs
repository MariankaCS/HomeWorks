using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_UnitTests
{
    public class Triangle
    {
        private Point p1, p2, p3;
        public Triangle(Point a, Point b, Point c)
        {
            p1 = a;
            p2 = b;
            p3 = c;
        }

        public double CloserTooOrigin()
        {
            List<Point> list = new List<Point>();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            double d = list.Min(cw => cw.Distance());
            return d;
        }

        public double Perimeter()
        {
            return p1.Distance(p2) + p2.Distance(p3) + p3.Distance(p1);
        }

        public double Square()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt((p * (p - p1.Distance(p2)) * (p - p2.Distance(p3)) * (p - p3.Distance(p1))));
        }


        public void Print()
        {
            Console.WriteLine(@"V1 = {0}, V2 = {1}, v3 = {2}", p1, p2, p3);
        }
    }
}
