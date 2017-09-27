using model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace idata
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> List();
        void Save(Department doc);
        void Insert(Department department);
    }
}
