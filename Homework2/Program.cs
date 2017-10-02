using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
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


        static void Main(string[] args)
        {

            //     a) read 3 float numbers and check: are they all belong to the range[-5, 5].

            //FloatFtomRange();


            //     b) read 3 integers and write max and min of them.

            //IntMaxMin();


            //     c) read number of HTTP Error(400, 401, 402, ...) and write the name of this error(Declare enum HTTPError)
            // HTTPErrorMessage1();
            //HTTPErrorMessage2();


            //     d) declare struct Dog with fields Name, Mark, Age.Declare variable myDog of Dog type and read values for it.
            //         Output myDos into console. (Declare method ToString in struct)
           
            ShowDogDetails();

        }

       // a) read 3 float numbers and check: are they all belong to the range[-5, 5]
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
        }

        // b) read 3 integers and write max and min of them.
        public static void IntMaxMin()
        { 
            Console.ReadKey();
            Console.WriteLine("Enter 3 integer numbers");
            int.TryParse(Console.ReadLine(), out int number1);
            int.TryParse(Console.ReadLine(), out int number2);
            int.TryParse(Console.ReadLine(), out int number3);
            int[] numbers = new int[] { number1, number2, number3 };
            int maxNumber = numbers.Max();
            int minNumber = numbers.Min();
            Console.WriteLine($"Max value is {maxNumber}, the Min number is {minNumber}");
        }

        //c) read number of HTTP Error(400, 401, 402, ...) and write the name of this error
        //(Declare enum HTTPError)        
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

        //c) variant 2 
        public static void HTTPErrorMessage2()
        {
            Console.WriteLine("Enter Http error");
            int.TryParse(Console.ReadLine(), out int choice);
            HTTPErrors error = (HTTPErrors)choice;
            Console.WriteLine($"{choice} error name is {error}.");
        }




        // d) declare struct Dog with fields Name, Mark, Age.Declare variable myDog of 
        //Dog type and read values for it.
        //Output myDos into console. (Declare method ToString in struct)

        public static void ShowDogDetails()
        {
            Dog myDog = new Dog();
            Console.WriteLine("Enter name of your dog");
            myDog.name = Console.ReadLine();

            Console.WriteLine("Enter your dog's mark");
            myDog.mark = Console.ReadLine();

            Console.WriteLine("Enter your dog's age");
            myDog.age = int.Parse(Console.ReadLine());
            myDog.ToString(myDog);
        }


        public struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public void ToString(Dog dog)
            {
                Console.WriteLine($"Your dog's name is {name}, his mark is {mark} and his age is {age} years ");
            }
        }
}
}
