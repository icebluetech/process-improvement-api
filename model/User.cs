using System;
using System.Collections.Generic;

namespace model
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public ICollection<Innovation> Innovations { get; set; }
    }
}
