using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> myList = new List<Shape>();
            //craete a list
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Enter name a Shape: 1. Circle 2. Square");

                    string choice = Console.ReadLine();
                    if ((choice != "1") && (choice != "2") || choice == null)
                    {
                        throw new FormatException("You entered invalid data");
                    }


                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Enter radius of circle");
                            if (!double.TryParse(Console.ReadLine(), out double radius))
                            {
                                throw new FormatException("You entered invalid data");
                            }
                            myList.Add(new Circle("Circle", radius));
                            break;

                        case "2":
                            Console.WriteLine("Enter side of Square");
                            if (!double.TryParse(Console.ReadLine(), out double side))
                            {
                                throw new FormatException("You entered invalid data");
                            }
                            myList.Add(new Square("Square", side));
                            break;
                        default:
                            Console.WriteLine("You entered wrong shape number");
                            break;
                    }
                }
                //print all shapes
                foreach (Shape a in myList)
                {
                    Console.WriteLine($"{a.Name}'s area is {a.Area():F2} and perimeter is {a.Perimeter():F2}");
                }

                //largest perimeter
                LargestPwerimeter(myList);

                //sort by area
                SortByArea(myList);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }

        /// <summary>
        /// Calculate the lasrgest perimeter and print the name of corresponding Shape
        /// </summary>
        static void LargestPwerimeter(List<Shape> myList)
        {

            double max = 0;
            string tempShape ="";
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i].Perimeter() > max)
                {
                    max = myList[i].Perimeter();
                    tempShape = myList[i].Name;
                }

                
            }
            Console.WriteLine($"The largest perimeter has a {tempShape}, it is {max:F2}");
        }

        /// <summary>
        /// Sort the list by area and print sorted list to Console
        /// </summary>
        static void SortByArea(List<Shape> myList)
        {
            myList.Sort();
            Console.WriteLine("Sorted list by area");
            foreach (Shape a in myList)
            {
                Console.WriteLine($"{ a.Area():F2}");
            }

        }
    }
}
