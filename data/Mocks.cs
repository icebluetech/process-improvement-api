using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data
{
    public class Mocks
    {
        public static IEnumerable<User> UserList()
        {
            return new List<User>()
            {
                new User { Id = 1, Name = "Chris Chehsire", avatar="face-8" },
                new User { Id = 2, Name = "Terri Cheshire", avatar="female-1" },
                new User { Id = 3, Name = "Scotty Martin", avatar="male-1" }
            };
        }
    }
}
