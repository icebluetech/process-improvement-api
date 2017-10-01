using imodel;
using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class Solution
    {
        public int Id { get; set; }

        public List<SolutionFile> SolutionFiles { get; set; }

        public int InnovationId { get; set; }
        public Innovation Innovation { get; set; }
    }
}
