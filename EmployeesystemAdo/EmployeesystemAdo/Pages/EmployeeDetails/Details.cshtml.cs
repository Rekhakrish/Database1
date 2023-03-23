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
    public class DetailsModel : PageModel
    {
        private readonly EmployeesystemAdo.Data.EmployeesystemAdoContext _context;

        public DetailsModel(EmployeesystemAdo.Data.EmployeesystemAdoContext context)
        {
            _context = context;
        }

      public Employee Employee { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Employee == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }
            else 
            {
                Employee = employee;
            }
            return Page();
        }
    }
}
