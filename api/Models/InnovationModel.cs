using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class InnovationModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<InnovationUser> InnovationUsers { get; set; }

        public DateTime Date { get; set; }

        public ICollection<Notification> Notifications { get; set; }

        public int InnovationTypeId { get; set; }
        public InnovationType Type { get; set; }

        public int InnovationCategoryId { get; set; }
        public InnovationCategory Category { get; set; }

        public string Why { get; set; }
        public string CurrentState { get; set; }
        public string FutureState { get; set; }

        public int? RootCauseAnalysisId { get; set; }
        public virtual RootCauseAnalysis RootCauseAnalysis { get; set; }

        public User Owner { get; set; }
    }
}
