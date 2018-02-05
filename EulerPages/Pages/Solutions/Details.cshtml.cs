using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EulerPages.Data;
using EulerPages.Models;

namespace EulerPages.Pages.Solutions
{
    public class DetailsModel : PageModel
    {
        private readonly EulerPages.Data.ProblemContext _context;

        public DetailsModel(EulerPages.Data.ProblemContext context)
        {
            _context = context;
        }

        public Solution Solution { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Solution = await _context.Solutions
                .Include(s => s.Problem).SingleOrDefaultAsync(m => m.SolutionId == id);

            if (Solution == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
