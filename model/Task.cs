using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int InnovationId { get; set; }
        public Innovation Innovation { get; set; }
    }
}
