using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Jobs
{
    public class Activity
    {
        public Activity(string name, int beginning, int end)
        {
            Name = name;
            Start = beginning;
            End = end;
        }

        public string Name { get; set; }
        public int Start { get; set; }
        public int End { get; set; }

        
    }
}
