using idata;
using model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ProcessImprovementContext _dbContext;
        public DepartmentRepository(ProcessImprovementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Department> List()
        {
            return _dbContext.Departments;
        }

        public void Save(Department department)
        {
            using (_dbContext)
            {
                _dbContext.Departments.Add(department);
                _dbContext.SaveChanges();
            }
        }

        public void Insert(Department department)
        {
            using (_dbContext)
            {
                _dbContext.Departments.Add(department);
                _dbContext.SaveChanges();
            }

        }
    }
}
