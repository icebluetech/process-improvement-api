using idata;
using Microsoft.EntityFrameworkCore;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data
{
    public class InnovationCategoryRepository : IInnovationCategoryRepository
    {
        private readonly ProcessImprovementContext _dbContext;
        public InnovationCategoryRepository(ProcessImprovementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<InnovationCategory> List()
        {
            return IncludeAll();
        }

        public InnovationCategory Get(int Id)
        {
            var all = IncludeAll();
            return all.Single(s => s.Id == Id);
        }

        public void Insert(InnovationCategory innovationCategory)
        {
            using (_dbContext)
            {
                _dbContext.InnovationCategories.Add(innovationCategory);
                _dbContext.SaveChanges();
            }

        }

        private IQueryable<InnovationCategory> IncludeAll()
        {
            return _dbContext.InnovationCategories;
        }

        public IEnumerable<InnovationCategory> Search(string term)
        {
            if (term != null)
            {
                return List().Where(u => u.Name.ToLower().Contains(term.ToLower()));
            }

            return List();
        }
    }
}
