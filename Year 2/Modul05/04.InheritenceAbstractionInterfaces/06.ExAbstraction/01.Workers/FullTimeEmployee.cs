using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Workers
{
    class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;
        private string employeeDepartment;

        public string EmployeePosition
        {
            get { return employeePosition; }
            private set { employeePosition = value; }
        }
        public string EmployeeDepartment
        {
            get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }

        public FullTimeEmployee(string employeeID, string employeeName,
            string employeeAddress, string employeePosition, string employeeDepartment)
            : base(employeeID, employeeName, employeeAddress)
        {
            EmployeePosition = employeePosition;
            EmployeeDepartment = employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine(EmployeePosition);
            Console.WriteLine(EmployeeDepartment);
        }
        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.80;
        }

        public override string GetDepartment()
        {
            return EmployeeDepartment;
        }

    }
}
