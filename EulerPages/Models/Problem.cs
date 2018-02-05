using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EulerPages.Models
{
    public class Problem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProblemId { get; set; }
        public string Title { get; set; }
        public string Question { get; set; }
        public int? Answer { get; set; }
        public ICollection<Solution> Solutions { get; set; }
    }
}
