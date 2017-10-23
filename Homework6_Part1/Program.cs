using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //In Main() method declare Dictionary PhoneBook for keeping pairs PersonName - PhoneNumber.
            //1) From file "phones.txt" read 9 pairs into PhoneBook.Write only PhoneNumbers into file "Phones.txt".
            //2) Find and print phone number by the given name(name input from console)
            //3) Change all phone numbers, which are in format 80######### into new format +380#########. The result write into file "New.txt"

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            using (StreamReader reader = new StreamReader(@"C:\Users\mtsiupka\Documents\Visual Studio 2017\Projects\Homeworks\Homework6_Part1\phones.txt"))
            {
                for (int i = 0; i < 9; i++)
                {
                    string[] lines = reader.ReadLine().Split(' ');
                    phoneBook.Add(lines[0], lines[1]);
                }
            }
            //names and phones
            AddPhonesOnConsole(phoneBook);

            //write phone into separate file
            WritePhoneIntoFile(phoneBook, @"C:\Users\mtsiupka\Documents\Visual Studio 2017\Projects\Homeworks\Homework6_Part1\Phones1.txt");

           //phones of requested people
            ShowPhoneNumberByName(phoneBook);

            //change numbers with 80 to +80 and write result into New file
            ChangePrefixesOfPhoneNumbers();

           Console.ReadLine();
        }

        /// <summary>
        /// Write all names and phones from dictionary on Console
        /// </summary>
        static void AddPhonesOnConsole(Dictionary<string, string> phoneBook)
        {
            Console.WriteLine("Dictionary pairs Name - Phone before manipulations");
            foreach (KeyValuePair<string, string> a in phoneBook)
            {
                    Console.WriteLine($"{a.Key}, {a.Value}");
            }
        }

        /// <summary>
        /// Write phone numbers into file
        /// </summary>
        static void WritePhoneIntoFile(Dictionary<string, string> phoneBook, string address)
        {
            using (StreamWriter writer = new StreamWriter(address))
            {           
                foreach (KeyValuePair<string, string> a in phoneBook)
                {
                    writer.WriteLine(a.Value);
                 }
            }
         }

        /// <summary>
        /// Display phone of the requested person
        /// </summary>
        static void ShowPhoneNumberByName(Dictionary<string, string> phoneBook)
        {
            Console.WriteLine("Enter name of the person whose phone number you are looking for");
            string choice = Console.ReadLine();

            string result = phoneBook.ContainsKey(choice) ? phoneBook[choice] : "There is no requested person in our list";
            Console.WriteLine("Phone of requested person"); 
            Console.WriteLine($"{result}");
        }

        /// <summary>
        /// Change phone numbers that start with 80 to +380
        /// </summary>
        static void ChangePrefixesOfPhoneNumbers()
        {         
            Dictionary<string, string> phoneBook1 = new Dictionary<string, string>();
            using (StreamReader reader = new StreamReader(@"C:\Users\mtsiupka\Documents\Visual Studio 2017\Projects\Homeworks\Homework6_Part1\phones.txt"))
            {
                for (int i = 0; i < 9; i++)
                {
                    string[] lines = reader.ReadLine().Split(' ');
                   
                    if (lines[1].StartsWith("80"))
                    {
                        lines[1]= lines[1].Insert(0, "+3");
                    }
                    phoneBook1.Add(lines[0], lines[1]);
                  //  Console.WriteLine(lines[1]);
                }
            }
            WritePhoneIntoFile(phoneBook1, @"C:\Users\mtsiupka\Documents\Visual Studio 2017\Projects\Homeworks\Homework6_Part1\New.txt");
        }
    }
}
