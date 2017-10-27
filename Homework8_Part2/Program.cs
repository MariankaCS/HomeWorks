using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] text = File.ReadAllLines(@"C:\Users\mtsiupka\Documents\Visual Studio 2017\Projects\Homeworks\Homework8_Part2\data.txt");

            //1) Count and write the number of symbols in every line.
            LengthOfEachLine(text);

            //2.1 Find the longestline 
            Console.WriteLine();
            FindTheLOngesLine(text);

            //2.2 find the shortest line
            Console.WriteLine();
            FindTheShortestLine(text);

            //3) Find and write only lines, which consist of word "var"
            Console.WriteLine();
            LineThatContainsVar(text);

            Console.ReadLine();
        }
        /// <summary>
        ///Count and write the number of symbols in every line.
        /// </summary>
        static void LengthOfEachLine(string[] text)
        {
            foreach (string a in text)
            {
                Console.WriteLine(a.Count());
            }
        }

        /// <summary>
        /// 2.1 Find the longest line  
        /// </summary>
        static void FindTheLOngesLine(string[] text)
        {
            int longest = text.Max(a => a.Count());
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Count() == longest)
                {
                    Console.WriteLine($"Logest string contains {longest} symbols. The string is :[{text[i]}]");
                }
            }
        }

        /// <summary>
        /// 2.2 Fnd the shortest line
        /// </summary>
        static void FindTheShortestLine(string[] text)
        {
            int shortest = text.Min(a => a.Length);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Count() == shortest)
                {
                    Console.WriteLine($"Shortest string contains {shortest} symbols. The string is :[{text[i]}]");
                }
            }
        }

        /// <summary>
        /// Find and write only lines, which consist of word "var"
        /// </summary>
        static void LineThatContainsVar(string[] text)
        {
            Console.WriteLine("Lines that contain var keyword:");
            foreach (string a in text)
            {
                if (a.Contains("var"))
                {
                    Console.WriteLine($"{a}");
                }
            }
        }

    }
}

