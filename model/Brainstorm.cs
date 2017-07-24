using imodel;
using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class Brainstorm: IBrainstorm
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string LevelOfEffort { get; set; }

        public string Impact { get; set; }

        public int InnovationId { get; set; }
        public Innovation Innovation { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
