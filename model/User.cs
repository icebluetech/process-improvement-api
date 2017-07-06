using imodel;
using System;
using System.Collections.Generic;

namespace model
{
    public class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Innovation> Innovations { get; set; }
    }
}
