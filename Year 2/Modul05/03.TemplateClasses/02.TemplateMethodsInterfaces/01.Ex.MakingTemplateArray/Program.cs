using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Ex.MakingTemplateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] nums = ArrayCreator.Create(5, 20);

            Console.WriteLine(string.Join(", ", strings));
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
