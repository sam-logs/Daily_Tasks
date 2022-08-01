using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Models
{
    public class EmployeeContent: DbContext
    {
        public EmployeeContent(DbContextOptions<EmployeeContent>options)
            :base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
