using model;
using System;
using System.Collections.Generic;
using System.Text;

namespace idata
{
    public interface IUserRoleRepository
    {
        IEnumerable<UserRole> List();
        void Insert(UserRole userRole);
        IEnumerable<UserRole> Search(string term);
    }
}
