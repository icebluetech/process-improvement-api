using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    public class InnovationUser
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int InnovationId { get; set; }
        public virtual Innovation Innovation { get; set; }

        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
    }
}
