using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class SolutionFile
    {
        public int Id { get; set; }

        public int SolutionFileTypeId { get; set; }
        public SolutionFileType SolutionFileType { get; set; }

        public string Expectation { get; set; }

        public int DocId { get; set; }
        public virtual Doc Doc { get; set; }
    }
}
