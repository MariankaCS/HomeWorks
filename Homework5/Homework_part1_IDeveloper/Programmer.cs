using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Programmer : IDeveloper
    {

        private string language;
        public string Tool
        {
            get { return language; }
            set { language = value;}
        }

        public int CompareTo(IDeveloper obj)
        {
            return Tool.CompareTo((obj as IDeveloper).Tool);

        }


        public string Create()
        {
            return $"I am a programmer and I programm in {Tool}";
        }

        public string Destroy()
        {
           return $"I can hack in {Tool}";
        }
    }
}
