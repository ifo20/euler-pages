using System.Collections.Generic;
using System.Threading.Tasks;
using EulerPages.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EulerPages.Models;

namespace EulerPages.Pages.Problems
{
    public class IndexModel : PageModel
    {
        private readonly ProblemContext _context;

        public IndexModel(ProblemContext context)
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