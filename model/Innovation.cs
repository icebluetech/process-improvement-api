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
        public string Title { get; set; }

        public int UserId { get; set; }
        public User Owner { get; set; }

        public DateTime Date { get; set; }

        public ICollection<Task> Tasks { get; set; }

        public int InnovationTypeId { get; set; }
        public InnovationType Type { get; set; }

        public int InnovationCategoryId { get; set; }
        public InnovationCategory Category { get; set; }

        public ICollection<User> Members { get; set; }

        public string Why { get; set; }

        public string CurrentState { get; set; }

        public string FutureState { get; set; }

    }
}
