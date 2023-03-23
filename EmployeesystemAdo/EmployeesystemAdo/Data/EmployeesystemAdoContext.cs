using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeesystemAdo.Models;

namespace EmployeesystemAdo.Data
{
    public class EmployeesystemAdoContext : DbContext
    {
        public EmployeesystemAdoContext (DbContextOptions<EmployeesystemAdoContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeesystemAdo.Models.Employee> Employee { get; set; } = default!;
    }
}
