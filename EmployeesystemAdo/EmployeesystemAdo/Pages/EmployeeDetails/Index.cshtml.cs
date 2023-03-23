using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeesystemAdo.Data;
using EmployeesystemAdo.Models;

namespace EmployeesystemAdo.Pages.EmployeeDetails
{
    public class IndexModel : PageModel
    {
        private readonly EmployeesystemAdo.Data.EmployeesystemAdoContext _context;

        public IndexModel(EmployeesystemAdo.Data.EmployeesystemAdoContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employee != null)
            {
                Employee = await _context.Employee.ToListAsync();
            }
        }
    }
}
