using idata;
using Microsoft.EntityFrameworkCore;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data
{
    public class InnovationTypeRepository : IInnovationTypeRepository
    {
        private readonly ProcessImprovementContext _dbContext;
        public InnovationTypeRepository(ProcessImprovementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<InnovationType> List()
        {
            return IncludeAll();
        }

        public InnovationType Get(int Id)
        {
            var all = IncludeAll();
            return all.Single(s => s.Id == Id);
        }

        public void Insert(InnovationType innovationType)
        {
            using (_dbContext)
            {
                _dbContext.InnovationTypes.Add(innovationType);
                _dbContext.SaveChanges();
            }

        }

        private IQueryable<InnovationType> IncludeAll()
        {
            return _dbContext.InnovationTypes;
        }

        public IEnumerable<InnovationType> Search(string term)
        {
            if (term != null)
            {
                return List().Where(u => u.Name.ToLower().Contains(term.ToLower()));
            }

            return List();
        }
    }
}
