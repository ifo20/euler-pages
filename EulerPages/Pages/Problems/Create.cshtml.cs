using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EulerPages.Models;

namespace EulerPages.Pages.Problems
{
    public class CreateModel : PageModel
    {
        private readonly EulerPages.Models.ProblemContext _context;

        public CreateModel(EulerPages.Models.ProblemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
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

            _context.Problem.Add(Problem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}