﻿
namespace EulerPages.Models
{
    public class Solution
    {
        public int SolutionId { get; set; }
        public int ProblemId { get; set; }
        public Problem Problem { get; set; }
        public string Text { get; set; }
        public string Code { get; set; }
        public int Score { get; set; }
    }
}
