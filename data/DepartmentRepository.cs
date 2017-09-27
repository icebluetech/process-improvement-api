using idata;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Department> Search(string term)
        {
            if (term != null)
            {
                return List().Where(u => u.Name.ToLower().Contains(term.ToLower()));
            }

            return List();
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
