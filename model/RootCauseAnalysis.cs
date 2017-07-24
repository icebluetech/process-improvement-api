using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace model
{
    public class RootCauseAnalysis
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Tool { get; set; }

        public string Description { get; set; }



        public int UserId { get; set; }
        public User User { get; set; }
    }
}
