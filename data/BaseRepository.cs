using idata;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data
{
    public class BaseRepository<T> : IBaseRepository<T> where T:class
    {
        private readonly ProcessImprovementContext _dbContext;
        public BaseRepository(ProcessImprovementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<T> List()
        {
            return _dbContext.Set<T>();
        }

        public IEnumerable<T> Search(Func<T, bool> exp)
        {
            if (exp != null)
            {
                return List().Where(exp);
            }

            return List();
        }

        public void Insert(T obj)
        {
            using (_dbContext)
            {
                _dbContext.Set<T>().Add(obj);
                _dbContext.SaveChanges();
            }

        }
    }
}
