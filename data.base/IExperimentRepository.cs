using model;
using System;
using System.Collections.Generic;
using System.Text;

namespace idata
{
    public interface IExperimentRepository
    {
        Experiment Get(int Id);
        IEnumerable<Experiment> List();
        void Insert(Experiment innovation);
    }
}
