using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ProductContext : DbContext
    {
        public ProductContext()
        {

        }
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
