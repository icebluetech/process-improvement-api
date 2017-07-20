﻿using imodel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace model
{
    public class User : IUser
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<InnovationUser> InnovationUsers { get; set; }

        public ICollection<Training> Trainings { get; set; }
    }
}
