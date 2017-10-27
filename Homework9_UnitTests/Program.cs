using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                List<Triangle> list = new List<Triangle>();
                list.Add(new Triangle(new Point(1, 2), new Point(1, 0), new Point(2, 2)));
                list.Add(new Triangle(new Point(2, 2), new Point(1, 1), new Point(1, 2)));
                list.Add(new Triangle(new Point(1, 0), new Point(1, 2), new Point(2, 1)));

                foreach (var item in list)
                {
                    item.Print();
                }

                var trmin = list.Where(c => c.CloserTooOrigin() == list.Min(c1 => c1.CloserTooOrigin()));

                foreach (var it in trmin)
                {
                    it.Print();
                    Console.WriteLine(it.CloserTooOrigin());
                }

                Console.ReadLine();
            }
        }
    }
}
