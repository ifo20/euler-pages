using EulerPages.Models;
using Microsoft.EntityFrameworkCore;

namespace EulerPages.Data
{
    public class ProblemContext : DbContext
    {
        public ProblemContext(DbContextOptions<ProblemContext> options) : base(options)
        {
            
        }

        public DbSet<Problem> Problems { get; set; }
        public DbSet<Solution> Solutions { get; set; }
    }
}
