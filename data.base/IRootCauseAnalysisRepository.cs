using model;
using System;
using System.Collections.Generic;
using System.Text;

namespace idata
{
    public interface IRootCauseAnalysisRepository
    {
        RootCauseAnalysis Get(int Id);
        IEnumerable<RootCauseAnalysis> List();
        void Insert(RootCauseAnalysis innovation);
    }
}
