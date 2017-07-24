using model;
using System;
using System.Collections.Generic;

namespace idata
{
    public interface IInnovationRepository
    {
        Innovation Get(int Id);
        IEnumerable<Innovation> List();
        void Insert(Innovation innovation);
    }
}
