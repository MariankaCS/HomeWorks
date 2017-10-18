using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.Create Console Application project in VS.
            //In the Main() method declare Dictionary<uint, string>.
            //Add to Dictionary from Console seven pairs(ID, Name) of some persons.
            //Ask user to enter ID, then find and write corresponding Name 
            //from your Dictionary.If you can't 
            //find this ID - say about it to user.
            Dictionary<uint, string> myDictionary = new Dictionary<uint, string>();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter ID");
                uint value = uint.Parse(Console.ReadLine());
                Console.WriteLine("Eneter name");
                string name = Console.ReadLine();
                myDictionary.Add(value, name);
            }

            FindNameINDictionary(myDictionary);
            Console.ReadLine();
        }

        static void FindNameINDictionary(Dictionary<uint, string> myDictionary)
        {
            Console.WriteLine("Enter ID of a person you want to retrieve");
            uint choice = uint.Parse(Console.ReadLine());

            string result = myDictionary.ContainsKey(choice) ? myDictionary[choice] : "There is no such ID";
            Console.WriteLine(result);
          
        }
    }
}
        
  

