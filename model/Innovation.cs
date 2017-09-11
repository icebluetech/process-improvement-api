﻿using imodel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace model
{
    public class Innovation : IInnovation
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Sponsor { get; set; }
        public string Customer { get; set; }
        public string Process { get; set; }
        public string Widget { get; set; }
        public string PrimaryDepartment { get; set; }
        

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

        public ICollection<Doc> Docs { get; set; }



    }
}
