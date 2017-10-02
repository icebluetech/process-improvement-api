using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class State
    {
        public int Id { get; set; }

        public int StateTypeId { get; set; }
        public virtual StateType StateType { get; set; } //current or future

        public int WidgetId { get; set; }
        public virtual Widget Widget { get; set; }

        public int Provided { get; set; }
        public int ProvidedMeasure { get; set; }
        public int TimeTaken { get; set; }
        public int TimeTakenMeasure { get; set; }
        public int Correct { get; set; }
        public int EmpSatisfied { get; set; }
        public int CustSatisfied { get; set; }
        public int BacklogNumber { get; set; }
        public int BacklogWork { get; set; }
        public int Handoffs { get; set; }
        public int Approvals { get; set; }

        public int InnovationId { get; set; }
        public Innovation Innovation { get; set; }

    }
}
