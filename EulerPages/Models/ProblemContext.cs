using Microsoft.EntityFrameworkCore;

namespace EulerPages.Models
{
    public class ProblemContext : DbContext
    {
        public ProblemContext(DbContextOptions<ProblemContext> options) : base(options)
        {
            
        }

        public DbSet<Problem> Movie { get; set; }
    }
}
