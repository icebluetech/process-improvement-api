using imodel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace model
{
    public class Innovation : IInnovation
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Task> Tasks { get; set; }

        public int InnovationTypeId { get; set; }
        public InnovationType InnovationType { get; set; }

        public int InnovationCategoryId { get; set; }
        public InnovationCategory InnovationCategory { get; set; }
    }
}
