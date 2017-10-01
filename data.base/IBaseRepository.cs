using model;
using System;
using System.Collections.Generic;

namespace idata
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> List();
        IEnumerable<T> Search(Func<T,bool> exp);
        void Insert(T obj);
    }
}
