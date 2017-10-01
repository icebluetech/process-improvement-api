using idata;
using Microsoft.EntityFrameworkCore;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data
{
    public class BrainstormRepository : IBrainstormRepository
    {
        private readonly ProcessImprovementContext _dbContext;
        public BrainstormRepository(ProcessImprovementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Brainstorm> List()
        {
            return IncludeAll();
        }

        public Brainstorm Get(int Id)
        {
            var all = IncludeAll();
            return all.Single(s => s.Id == Id);
        }

        public void Insert(Brainstorm brainstorm)
        {
            using (_dbContext)
            {
                _dbContext.Brainstorms.Add(brainstorm);
                _dbContext.SaveChanges();
            }

        }

        private IQueryable<Brainstorm> IncludeAll()
        {
            return _dbContext.Brainstorms.Include(p => p.Innovation);
        }
    }
}
