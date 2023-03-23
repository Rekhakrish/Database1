using EmployeesystemAdo.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeesystemAdo.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EmployeesystemAdoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EmployeesystemAdoContext>>()))
            {
                if (context == null || context.Employee == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }

                context.Employee.AddRange(
                    new Employee
                    {
                        Name = "Rekha Krishnakumar",
                        Jobrole = "Programmer",
                        DateofBirth = DateTime.Parse("1998-7-31"),
                        Salary = 500000
                    },

                    new Employee
                    {
                        Name = "Ram Illagovan",
                        Jobrole = "Programmer",
                        DateofBirth = DateTime.Parse("1996-6-12"),
                        Salary = 55000
                    },

                    new Employee
                    {
                        Name = "Ramya Manivannan",
                        Jobrole = "Programmer",
                        DateofBirth = DateTime.Parse("1999-12-31"),
                        Salary = 500000
                    },

                    new Employee
                    {
                        Name = "Srinivas ravi",
                        Jobrole = "Programmer",
                        DateofBirth = DateTime.Parse("2000-7-07"),
                        Salary = 500000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
