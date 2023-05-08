using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace the_olderst
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesByDepartments = new Dictionary<string, List<Employee>>();

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ').ToArray();
                string name = inputs[0];
                double salary = double.Parse(inputs[1]);
                string position = inputs[2];
                string department = inputs[3];
                if (inputs.Length==6)
                {
                    string email = inputs[4];
                    int age = int.Parse(inputs[5]);
                }
                else if(inputs[4].Contains("@"))
                {
                    string email = inputs[4];
                }
                else
                {
                    int age = int.Parse(inputs[4]);
                }

                if (!employeesByDepartments.ContainsKey(department))
                {
                    employeesByDepartments.Add(department, new List<Employee>());
                }

            }
        }
    }
}
