using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Workers
{
    abstract class BaseEmployee
    {
        private string employeeID;
        private string employeeName;
        private string employeeAddress;

        public string EmployeeID
        {
            get { return employeeID; }
            protected set { employeeID = value; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            protected set { employeeName = value; }
        }
        public string EmployeeAddress
        {
            get { return employeeAddress; }
            protected set { employeeAddress = value; }
        }
        protected BaseEmployee(string employeeID, string employeeName, string employeeAddress)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            EmployeeAddress = employeeAddress;
        }

        public virtual void Show()
        {
            Console.WriteLine($"{EmployeeID} {EmployeeName} {employeeAddress}");
        }

        abstract public double CalculateSalary(int workingHours);

        abstract public string GetDepartment();

    }
}
