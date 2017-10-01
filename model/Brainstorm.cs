using imodel;
using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class Brainstorm: IBrainstorm
    {
        public int Id { get; set; }

        public List<BrainstormFile> BrainstormFiles { get; set; }

        public int InnovationId { get; set; }
        public Innovation Innovation { get; set; }
    }
}
