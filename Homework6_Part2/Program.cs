using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            //B) Write a method ReadNumber(int start, int end), that reads from Console (or from file) integer number 
            //and return it, if it is in the range[start...end]. 
            //If an invalid number or non-number text is read, the method should throw an exception.
            //Using this method write a method Main(), that has to enter 10 numbers:
            //a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100
            List<int> myList = new List<int>();
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    int a = ReadNumber(1, 100);
                    myList.Add(a);
                }

                myList.Sort();
                Console.WriteLine("Sorted List of integers");
                foreach (int a in myList)
                {
                    Console.WriteLine(a);
                }
            }
            catch (InvalidDataException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Read number and return it if it is within specified range
        /// if not throw exception
        /// </summary>
        static int ReadNumber(int start, int end)
        {
            Console.WriteLine("Pleae enter an intger from range [1...100]");
            if ((!int.TryParse(Console.ReadLine(), out int number)) || ((number <= start) || (number >= end)))
            {
                throw new InvalidDataException("You entered invalid value. Only integers witong range [1...100] are supported. Try again.");
            }
            else
            {
                return number;
            }
        }
    }
}
