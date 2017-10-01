using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class BrainstormFile
    {
        public int Id { get; set; }

        public int BrainstormFileTypeId { get; set; }
        public BrainstormFileType BrainstormFileType { get; set; }

        public int? BrainstormId { get; set; }
        public virtual Brainstorm Brainstorm { get; set; }

        public string Expectation { get; set; }

        public int DocId { get; set; }
        public virtual Doc Doc { get; set; }
    }
}
