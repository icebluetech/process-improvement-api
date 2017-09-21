using model;
using System;
using System.Collections.Generic;

namespace idata
{
    public interface IUserRepository
    {
        IEnumerable<User> List();
        IEnumerable<User> Search(string term);
        void Insert(User user);
    }
}
