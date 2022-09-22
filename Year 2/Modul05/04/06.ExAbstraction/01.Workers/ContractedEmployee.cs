using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Workers
{
    class ContractedEmployee : BaseEmployee
    {
        private string employeeTask;
        private string employeeDepartment;

        public string EmployeeTask
        {
            get { return employeeTask; }
            set { employeeTask = value; }
        }
        public string EmployeeDepartment
        {
            get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }


        public ContractedEmployee(string employeeID, string employeeName
            , string employeeAddress, string employeeTask, string employeeDepartment)
            : base(employeeID, employeeName, employeeAddress)
        {
            EmployeeTask = employeeTask;
            EmployeeDepartment = employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine(EmployeeTask);
        }

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20;
        }

        public override string GetDepartment()
        {
            return EmployeeDepartment;
        }
    }
}
