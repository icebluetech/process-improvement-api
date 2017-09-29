using model;
using System;
using System.Collections.Generic;

namespace idata
{
    public interface IInnovationUserRepository
    {
        IEnumerable<InnovationUser> List();
        void Insert(InnovationUser innovationUser);
        void Insert(IEnumerable<InnovationUser> innovationUsers);
    }
}
