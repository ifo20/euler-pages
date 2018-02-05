using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EulerPages.Models
{
    public class Solution
    {
        public int SolutionId { get; set; }
        public int ProblemId { get; set; }
        public Problem Problem { get; set; }
        public string Text { get; set; }
    }
}
