using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            //A) Create Console Application project.
            //Use classes Shape, Circle, Square from your previous homework.
            //Use Linq and string functions to complete next tasks:
            //1) Create list of Shape and fill it with 6 different shapes(Circle and Square).
            //2) Find and write into the file shapes with area from range[10, 100]
            //3) Find and write into the file shapes which name contains letter 'a'
            //4) Find and remove from the list all shapes with perimeter less then 
            //5.Write resulted list into Console

            //1) Create list of Shape and fill it with 6 different shapes(Circle and Square)
            List<Shape> myList = new List<Shape>();
            myList.Add(new Circle("Sqackly", 0.5));
            myList.Add(new Circle("Freely", 3));
            myList.Add(new Square("Backy", 6));
            myList.Add(new Circle("Funny", 7));
            myList.Add(new Square("Mouse", 0.3));
            myList.Add(new Square("Flore", 9));

            //print  name, area and perimeter in original list
            foreach (Shape a in myList)
            {
                Console.WriteLine($"{a.Name}'s area is {a.Area():F2} and perimeter is {a.Perimeter():F2}");
            }

            //find and save shapes with area witing range [10...100]
            AreaFromRange(myList);

            //find and save into file objects with name that contains letter "a"
            NamesContainsA(myList);

            //remove all shapes that have perimeter less than 5
            Console.WriteLine();
            RemoveBiggerThan30(myList);
            Console.ReadLine();

        }
        /// <summary>
        /// Find and write into the file shapes with area from range[10, 100] 
        /// </summary>
        static void AreaFromRange(List<Shape> myList)
        {
            var areas = from s in myList
                        where (s.Area() > 10 && s.Area() < 100)
                        select s;

            using (StreamWriter writer = new StreamWriter(@"C:\Users\mtsiupka\Documents\Visual Studio 2017\Projects\Homeworks\Homework8\areas.txt"))
            {
                foreach (var a in areas)
                {
                    writer.WriteLine($"{a.Name} with area {a.Area():F2}");
                }
            }
        }

        /// <summary>
        /// 3) Find and write into the file shapes which name contains letter 'a'
        /// </summary>
        static void NamesContainsA(List<Shape> myList)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\mtsiupka\Documents\Visual Studio 2017\Projects\Homeworks\Homework8\nameswitha.txt"))
            {
                foreach (var a in myList)
                {
                    if (a.Name.Contains("a"))
                    {
                        writer.WriteLine($"{a.Name} with area {a.Area():F2} and perimeter {a.Perimeter():F2}");
                    }
                }
            }
        }
        /// <summary>
        /// Find and remove from the list all shapes with perimeter less than 5.Write
        /// resulted list into Console
        /// </summary>
        static void RemoveBiggerThan30(List<Shape> myList)
        {
            myList.RemoveAll(c => c.Perimeter() < 5);
            Console.WriteLine("Names of Shapes with perimeter bigger than 5");
            foreach (var a in myList)
            {
                Console.WriteLine(a.Name);
            }


        }

    }
}
