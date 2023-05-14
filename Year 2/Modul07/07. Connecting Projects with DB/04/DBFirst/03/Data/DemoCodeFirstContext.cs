using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _03.Data
{
    internal class DemoCodeFirstContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;Database = DemoCodeFirst; Integrated Security = true;");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
