using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EulerPages.Models;

namespace EulerPages.Pages.Problems
{
    public class IndexModel : PageModel
    {
        private readonly EulerPages.Models.ProblemContext _context;

        public IndexModel(EulerPages.Models.ProblemContext context)
        {
            _context = context;
        }

        public IList<Problem> Problem { get; set; }

        public async Task OnGetAsync()
        {
            Problem = await _context.Problems.ToListAsync();
        }
    }
}