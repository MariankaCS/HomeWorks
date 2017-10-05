using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of task to run: " + Environment.NewLine +
                "1 - Read the text as a string value and calculate the counts of characters 'a', 'o', 'i', 'e' in this text." + Environment.NewLine+
                "2 - Ask user to enter the number of month. Read the value and write the number of days in this month." + Environment.NewLine +
                "3 - Enter 10 integer numbers. Calculate the sum of first 5 elements if they are positive" + Environment.NewLine +
                "    or product of last 5 element in the other case." + Environment.NewLine +
                "C - To clear console" + Environment.NewLine+
                "0 - to exit");
            string choice = Console.ReadLine().ToUpper().LastOrDefault().ToString();
            switch (choice)
            {
                case "1":
                    NumberOfCharacters();
                    break;

                case "2":
                    NumberOfDaysInMonth1();
                    Console.ReadKey();
                    NumberOfDaysInMonth2();
                    break;

                case "3":
                    SumOrProduct();
                    break;

                case "C":
                    Console.Clear();
                    break;

                case "0":
                    Environment.Exit(exitCode: 0);
                    break;

                default:
                    Main(args);
                    break;
            }
            Console.WriteLine();
            Main(args);
        }

        /// <summary>
        ///1. Read the text as a string value and calculate the counts of characters 
        ///'a', 'o', 'i', 'e' in this text.
        /// </summary>
        public static void NumberOfCharacters()
        {
            Console.WriteLine("Enter a string that contains letter 'a', 'o', 'i', 'e' ");
            char[] characters = Console.ReadLine().ToLower().ToCharArray();
            int numberOfA = 0;
            int numberOfO = 0;
            int numberOfI = 0;
            int numberOfE = 0;
            foreach (char ch in characters)
            {
                switch (ch)
                {
                    case 'a':
                        ++numberOfA;
                        break;
                    case 'o':
                        ++numberOfO;
                        break;
                    case 'i':
                        ++numberOfI;
                        break;
                    case 'e':
                        ++numberOfE;
                        break;
                }
            }
            Console.WriteLine($"Number of 'a' {numberOfA}, Number of 'o' {numberOfO}, Number of 'i' {numberOfI}, Number of 'e' {numberOfE}");
        }

        /// <summary>
        /// b) Ask user to enter the number of month. Read the value and 
        /// write the number of days in this month.
        /// </summary>
        public static void NumberOfDaysInMonth1()
        {
            int daysInMonth = 0;
            Console.WriteLine("Enter 4-digit number of year");
            int.TryParse(Console.ReadLine(), out int year);
            if (year>DateTime.MaxValue.Year || year<DateTime.MinValue.Year)
            {
                Console.WriteLine("There is no such year");
            }
            else
            {
                Console.WriteLine("Enter number of month");
                int.TryParse(Console.ReadLine(), out int month);
                
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("There is no such month");
                }
                else
                {
                    daysInMonth = DateTime.DaysInMonth(year, month);
                    Console.WriteLine($"There are {daysInMonth} days in entered month");

                }
            }
       
            

        }
        
        /// <summary>
        /// 2nd variand of task b
        /// </summary>
        public static void NumberOfDaysInMonth2()
        {
           
            Console.WriteLine("Enter numer of month");
            int.TryParse(Console.ReadLine(), out int month);

            switch (month)
            {
                case 1:
                    Console.WriteLine("There are 31 days in January");
                    break;

                case 2:
                    Console.WriteLine("There are 28 or 29 days in February");
                    break;

                case 3:
                    Console.WriteLine("There are 31 days in March");
                    break;

                case 4:
                    Console.WriteLine("There are 30 days in April");
                    break;

                case 5:
                    Console.WriteLine("There are 31 days in May");
                    break;

                case 6:
                    Console.WriteLine("There are 30 days in June");
                    break;

                case 7:
                    Console.WriteLine("There are 31 days in July");
                    break;

                case 8:
                    Console.WriteLine("There are 31 days in August");
                    break;

                case 9:
                    Console.WriteLine("There are 30 days in September");
                    break;

                case 10:
                    Console.WriteLine("There are 31 days in October");
                    break;

                case 11:
                    Console.WriteLine("There are 30 days in November");
                    break;

                case 12:
                    Console.WriteLine("There are 31 days in December");
                    break;

                default:
                    Console.WriteLine("There is no such month");
                    break;
            }
           // Console.WriteLine($"There are {daysInMonth} days in entered month");

        }

        /// <summary>
        /// Enter 10 integer numbers. Calculate the sum of first 5 elements if they are positive
        /// or product of last 5 element in the other case.
        /// </summary>
        public static void SumOrProduct()
        {
            Console.WriteLine("Enter 10 integer numbers");
            string[] srt = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int[] numbersArrary = Array.ConvertAll(srt, int.Parse);
            int result = 0;
                        
                if ((numbersArrary[0] > 0) && (numbersArrary[1] > 0) && (numbersArrary[2] > 0) && (numbersArrary[3] > 0) && (numbersArrary[4] > 0))
                {
                    result = numbersArrary[0] + numbersArrary[1] + numbersArrary[2] + numbersArrary[3] + numbersArrary[4];
                }
                else
                {
                    result = numbersArrary[5] * numbersArrary[6] * numbersArrary[7] * numbersArrary[8] * numbersArrary[9];
                }
          
            Console.WriteLine($"{(((numbersArrary[0] > 0) && (numbersArrary[1] > 0) && (numbersArrary[2] > 0) && (numbersArrary[3] > 0) && (numbersArrary[4] > 0))? "Sum" : "Product")} of entered numbers is {result}");

        }
    }
}
