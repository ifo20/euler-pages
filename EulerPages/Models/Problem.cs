using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EulerPages.Models
{
    public class Problem : IProblem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Question { get; set; }
        public bool Solved { get; set; }
        public int Answer { get; set; }
        public string Solution { get; set; }
    }
}
