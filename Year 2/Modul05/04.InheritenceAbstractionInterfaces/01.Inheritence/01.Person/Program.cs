using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(20, "Pesho");
            Student student = new Student(15, "Ivan", "Kliment");
            person.Sleep();
            student.Sleep();
            Console.WriteLine(student.Name);
            Console.WriteLine(person.Name);
            Console.WriteLine(student.School);
        }
    }
}
