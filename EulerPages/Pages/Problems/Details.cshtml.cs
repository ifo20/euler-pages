using System.Threading.Tasks;
using EulerPages.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EulerPages.Models;

namespace EulerPages.Pages.Problems
{
    public class DetailsModel : PageModel
    {
        private readonly ProblemContext _context;

        public DetailsModel(ProblemContext context)
        {
            _context = context;
        }

        public Problem Problem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Problem = await _context.Problems.SingleOrDefaultAsync(m => m.ProblemId == id);

            if (Problem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}