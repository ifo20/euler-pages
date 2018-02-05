using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EulerPages.Models
{
    public class Problem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProblemId { get; set; }
        public string Title { get; set; }
        public string Question { get; set; }
        [DisplayFormat(NullDisplayText = "Not answered yet")]
        public int? Answer { get; set; }
        public ICollection<Solution> Solutions { get; set; }
    }
}
