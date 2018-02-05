using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EulerPages.Models;

namespace EulerPages.Pages.Problems
{
    public class DeleteModel : PageModel
    {
        private readonly EulerPages.Models.ProblemContext _context;

        public DeleteModel(EulerPages.Models.ProblemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Problem Problem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Problem = await _context.Problem.SingleOrDefaultAsync(m => m.Id == id);

            if (Problem == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Problem = await _context.Problem.FindAsync(id);

            if (Problem != null)
            {
                _context.Problem.Remove(Problem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
