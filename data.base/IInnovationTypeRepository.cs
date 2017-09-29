using model;
using System;
using System.Collections.Generic;

namespace idata
{
    public interface IInnovationTypeRepository
    {
        IEnumerable<InnovationType> List();
        IEnumerable<InnovationType> Search(string term);
        void Insert(InnovationType innovationType);
    }
}
