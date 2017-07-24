using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace model
{
    public class Experiment
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string What { get; set; }
        public string Who { get; set; }
        public string When { get; set; }
        public string Status { get; set; }
        public DateTime CompletionDate { get; set; }

        public int InnovationId { get; set; }
        public Innovation Innovation { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
