using model;
using System;
using System.Collections.Generic;

namespace idata
{
    public interface IInnovationCategoryRepository
    {
        IEnumerable<InnovationCategory> List();
        IEnumerable<InnovationCategory> Search(string term);
        void Insert(InnovationCategory innovationType);
    }
}
