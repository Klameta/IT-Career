using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Patients
{
    class Patient : Person
    {
        protected float w;

        public void Something()
        {
            double w = 0.5;
            this.w = 3.4f;
            base.w = 100;
            Console.WriteLine(w);
            Console.WriteLine(this.w);
            Console.WriteLine(base.w);
        }
    }
}
