using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Please, enter an integer value");
            int.TryParse(Console.ReadLine(), out int a);
            
            Console.WriteLine($"Area of a square is {Area(a)}");
            Console.WriteLine($"Perimeter of a square is {Permiterer(a)}");


            //Task2
            Console.ReadKey();
            NameAge();

            //Task3
            Console.ReadKey();
            Console.WriteLine("Please enter circle radius");
            double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double r);
            Console.WriteLine($"Length of a circle is {CircleLength(r):F2}");
            Console.WriteLine($"Length of a circle is {CircleArea(r):F2}");
            Console.WriteLine($"Length of a circle is {CircleVolume(r):F2}");

        }

        //Area of a square
        public static int Area(int a)
        {
            int area = a * a;
            return area;
        }

        // Perimeter of a square
        public static int Permiterer(int a)
        {
            int perimeter = 4 * a;
            return perimeter;
        }

        //Name & Age
        public static void NameAge()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"What's your age, {name}?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your name is {name}, Your age is {age}");

        }

        //
        public static double CircleLength(double r)
        {
            double length = 2 * Math.PI * r;
            return length;
        }

        public static double CircleArea(double r)
        {
            double area = Math.PI * r *r;
            return area;
        }

        public static double CircleVolume(double r)
        {
            double volume =(4/3) * Math.PI * r * r *r;
            return volume;
        }
        //	  d) Read double number r and calculate the length (l=2*pi*r), 
        //area (S=pi*r*r) and volume (4/3*pi*r*r*r) of a circle of given r  

    }
}
