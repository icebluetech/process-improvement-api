using model;
using System;
using System.Collections.Generic;

namespace idata
{
    public interface IProcessRepository
    {
        IEnumerable<Process> List();
        IEnumerable<Process> Search(string term);
        void Insert(Process process);
    }
}
