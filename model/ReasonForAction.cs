using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace model
{
    public class ReasonForAction
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Reason { get; set; }
        
        public int InnovationId { get; set; }
        public virtual Innovation Innovation { get; set; }
    }
}
