using System;
using System.Globalization;
using System.Linq;

namespace Homework2
{
    enum HTTPErrors
    {
         BadRequest = 400,
         Unauthorized = 401,
         PaymentRequired = 402,
         Forbidden = 403,
         NotFound = 404,
         MethodNotAllowed = 405,
         Unknown
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Enter number of the task" + Environment.NewLine +
                "1 - read 3 float numbers and check: are they all belong to the range[-5, 5]" + Environment.NewLine +
                "2 - read 3 integers and write max and min of them" + Environment.NewLine +
                "3 - read number of HTTP Error(400, 401, 402, ...) and write the name of this error" + Environment.NewLine +
                "4 - declare struct Dog with fields Name, Mark, Age.Declare variable myDog of Dog type and read values for it. " +
                "Output myDos into console. (Declare method ToString in struct)" + Environment.NewLine +
                "0 - to exit" + Environment.NewLine+
                "C - to Clear" );
                
                
            switch (Console.ReadLine().ToUpper().LastOrDefault().ToString())
            {
                case "1":
                    FloatFtomRange();
                    break;
                case "2":

                    IntMaxMin();
                    break;

                case "3":
                    HTTPErrorMessageWithLoop();
                    HTTPErrorMessage2();             
                    break;
                case "4":
                    ShowDogDetails();
                    break;
                case "C":
                    Console.Clear();
                    Main(args);
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

       // 

        /// <summary>
        /// a) read 3 float numbers and check: are they all belong to the range[-5, 5]
        /// </summary>
        public static void FloatFtomRange()
        {
            Console.WriteLine("Enter 3 float numbers");
            float.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out float number1);
            float.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out float number2);
            float.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out float number3);
            bool result1 = (number1 >= -5) && (number1 <= 5);
            bool result2 = (number2 >= -5) && (number2 <= 5);
            bool result3 = (number3 >= -5) && (number3 <= 5);
            
            Console.WriteLine($"First number belongs to range [-5, 5]{result1}");
            Console.WriteLine($"Second number belongs to range [-5, 5]{result2}");
            Console.WriteLine($"Third number belongs to range [-5, 5]{result3}");
            Console.WriteLine($"All 3 numbers belog to range [-5, 5] {result1 && result2 && result3}");
        }
        /// <summary>
        /// b) read 3 integers and write max and min of them.
        /// </summary> 
        public static void IntMaxMin()
        { 
            Console.WriteLine("Enter 3 integer numbers");
            int.TryParse(Console.ReadLine(), out int number1);
            int.TryParse(Console.ReadLine(), out int number2);
            int.TryParse(Console.ReadLine(), out int number3);
            int maxNumber = Math.Max(number1, Math.Max(number2, number3));
            int minNumber = Math.Min(number1, Math.Min(number2, number3));

            Console.WriteLine($"Max value is {maxNumber}, the Min number is {minNumber}");
        }

        /// <summary>
        /// c) read number of HTTP Error(400, 401, 402, ...) and write the name of this error
        /// (Declare enum HTTPError) 
        /// </summary>    
        public static void HTTPErrorMessageWithLoop()
        {
            Console.WriteLine("Enter Http error number");
            int.TryParse(Console.ReadLine(), out int choice);
            HTTPErrors error;
            if (Enum.IsDefined(typeof(HTTPErrors), choice))
                error = (HTTPErrors)choice;
            else
                error = HTTPErrors.Unknown;

            Console.WriteLine($"{choice} error name is {error}.");

        }

        /// <summary>
        /// c) variant 2 
        /// </summary>
        public static void HTTPErrorMessage2()
        {
            Console.WriteLine("Enter Http error");
            int.TryParse(Console.ReadLine(), out int choice);
            HTTPErrors error = (HTTPErrors)choice;
            Console.WriteLine($"{choice} error name is {error}.");
        }

        /// <summary>
        ///  d) declare struct Dog with fields Name, Mark, Age.Declare variable myDog of 
        /// Dog type and read values for it.
        /// Output myDos into console. (Declare method ToString in struct)
        /// </summary>
        public static void ShowDogDetails()
        {
            Dog myDog = new Dog();
            Console.WriteLine("Enter name of your dog");
            myDog.Name = Console.ReadLine();

            Console.WriteLine("Enter your dog's mark");
            myDog.Mark = Console.ReadLine();

            Console.WriteLine("Enter your dog's age in years");
            myDog.Age = int.Parse(Console.ReadLine());
            Console.WriteLine(myDog);
        }


        
}

    struct Dog
    {
        public string Name;
        public string Mark;
        public int Age;

        public override string ToString()
        {
            return $"Your dog's name is {Name}, his mark is {Mark} and his age is {Age} years ";
        }

    }
}
