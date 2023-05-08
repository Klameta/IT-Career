using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace the_olderst
{
    class Employee
    {
        private string name;
        private double salary;
        private string positiong;
        private string department;
        private string email = "n/a";
        private int age = -1;

        public string Name
        {
            get => name;
            set
            {
                if (value.Length <= 2)
                {
                    Console.WriteLine("Name should be longer than 0 letters");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (this.age < 0)
                {
                    Console.WriteLine("age should be mpre than 0");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public double Salary  { get => salary; set => salary = value; }
        public string Positiong { get => positiong; set => positiong = value; }
        public string Department { get => department; set => department = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return $"{name} {salary:F2} {email} {age}";


        }


    }
}