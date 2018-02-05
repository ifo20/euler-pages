using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EulerPages.Data;
using EulerPages.Models;

namespace EulerPages.Pages.Solutions
{
    public class EditModel : PageModel
    {
        private readonly EulerPages.Data.ProblemContext _context;

        public EditModel(EulerPages.Data.ProblemContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["ProblemId"] = new SelectList(_context.Problems, "ProblemId", "ProblemId");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Solution).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SolutionExists(Solution.SolutionId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SolutionExists(int id)
        {
            return _context.Solutions.Any(e => e.SolutionId == id);
        }
    }
}
