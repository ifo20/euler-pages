using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EulerPages.Data;
using EulerPages.Models;

namespace EulerPages.Pages.Problems
{
    public class CreateModel : PageModel
    {
        private readonly EulerPages.Data.ProblemContext _context;

        public CreateModel(EulerPages.Data.ProblemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ProblemId"] = new SelectList(_context.Problems, "ProblemId", "ProblemId");
            return Page();
        }

        [BindProperty]
        public Problem Problem { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Problems.Add(Problem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}