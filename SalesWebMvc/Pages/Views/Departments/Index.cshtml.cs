using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Pages.Models;

namespace SalesWebMvc.Pages.Views.Departments
{
    public class IndexModel : PageModel
    {
        private readonly SalesWebMvc.Data.SalesWebMvcContext _context;

        public IndexModel(SalesWebMvc.Data.SalesWebMvcContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; }

        public async Task OnGetAsync()
        {
            Department = await _context.Department.ToListAsync();
        }
    }
}
