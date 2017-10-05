using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class ActionPlan
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }
        public virtual User AssignedTo { get; set; }

        public DateTime Due { get; set; }
        public DateTime Completed { get; set; }

        public int StatusId { get; set; }
        public virtual Status Status { get; set; }

        public int InnovationId { get; set; }
        public Innovation Innovation { get; set; }
    }
}
