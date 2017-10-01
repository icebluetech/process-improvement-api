using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace model
{
    public class InnovationUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("InnovationId")]
        public int InnovationId { get; set; }
        public virtual Innovation Innovation { get; set; }

        [ForeignKey("UserRoleId")]
        public int UserRoleId { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
