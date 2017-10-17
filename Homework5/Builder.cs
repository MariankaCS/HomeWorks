using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Builder : IDeveloper, IComparable<Builder>
    {
        private string tool;
        public string Tool
        {
            get {return tool;}
            set {tool = value;}
        }

        public int CompareTo(Builder obj)
        {
            return Tool.CompareTo(obj.Tool);
        }


        public string Create()
        {
            return $"I am a builder and I build with {Tool}";
        }

        public string Destroy()
        {
            return $"I can destroy with {Tool}";
        }
    }
}
