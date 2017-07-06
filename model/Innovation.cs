using imodel;
using System;
using System.Collections.Generic;
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
    }
}
