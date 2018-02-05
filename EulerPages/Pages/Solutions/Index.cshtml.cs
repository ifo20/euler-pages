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
    public class IndexModel : PageModel
    {
        private readonly EulerPages.Data.ProblemContext _context;

        public IndexModel(EulerPages.Data.ProblemContext context)
        {
            _context = context;
        }

        public IList<Solution> Solution { get;set; }

        public async Task OnGetAsync()
        {
            Solution = await _context.Solutions
                .Include(s => s.Problem)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
