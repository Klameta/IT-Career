using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Data
{
    public class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
