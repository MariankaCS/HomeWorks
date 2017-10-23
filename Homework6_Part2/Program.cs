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

            ReadNumber(11, 2);
            Console.ReadLine();
        }
        static void ReadNumber(int start, int end)
        {
            int number;
            using (StreamReader reader = new StreamReader(@"C:\Users\mtsiupka\Documents\Visual Studio 2017\Projects\Homeworks\Homework6_Part2\Integers.txt"))
            {
                //number = int.Parse(reader.ReadLine());
                if (!int.TryParse(reader.ReadLine(), out number))
                {
                    throw new InvalidDataException("Wrong format");
                }

            }
            if (start < end)
            {
                if ((number > start) && (number < end))
                {
                    Console.WriteLine(number);
                }
            }
            else if ((start > end)||(start==end))
            {
                Console.WriteLine("Please make sure start is less than end");
            }
                
        }

    }
}
