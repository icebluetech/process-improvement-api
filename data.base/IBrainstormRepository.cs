using model;
using System;
using System.Collections.Generic;
using System.Text;

namespace idata
{
    public interface IBrainstormRepository
    {
        Brainstorm Get(int Id);
        IEnumerable<Brainstorm> List();
        void Insert(Brainstorm innovation);
    }
}
