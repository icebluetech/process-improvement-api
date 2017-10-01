using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace model
{
    public class Result
    {
        public int Id { get; set; }

        public List<ResultEntry> ResultEntries { get; set; }

        public int InnovationId { get; set; }
        public Innovation Innovation { get; set; }
    }
}
