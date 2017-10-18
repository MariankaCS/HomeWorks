using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            List <IDeveloper> workers = new List<IDeveloper>();
            IDeveloper builder1 = new Builder();
            builder1.Tool = "hammer";
            IDeveloper builder2 = new Builder();
            builder2.Tool = "saw";
            IDeveloper developer1 = new Programmer();
            developer1.Tool = "C#";
            IDeveloper developer2 = new Programmer();
            developer2.Tool = "Java";
            IDeveloper developer3 = new Programmer();
            developer3.Tool = "Go";

            workers.Add(builder1);
            workers.Add(builder2);
            workers.Add(developer1);
            workers.Add(developer2);
            workers.Add(developer3);

            Console.WriteLine("List of Builders and Programmers");
            foreach (IDeveloper d in workers)
            {
                Console.WriteLine(d.Create());
                Console.WriteLine(d.Destroy());
            }

            workers.Sort();

            Console.WriteLine("List of sorted Tools");
            foreach (IDeveloper d in workers)
            {
                Console.WriteLine(d.Tool);
            }
            Console.ReadLine();


        }
    }
}
