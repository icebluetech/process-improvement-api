using idata;
using Microsoft.EntityFrameworkCore;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data
{
    public class ExperimentRepository : IExperimentRepository
    {
        private readonly ProcessImprovementContext _dbContext;
        public ExperimentRepository(ProcessImprovementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Experiment> List()
        {
            return IncludeAll();
        }

        public Experiment Get(int Id)
        {
            var all = IncludeAll();
            return all.Single(s => s.Id == Id);
        }

        public void Insert(Experiment experiment)
        {
            using (_dbContext)
            {
                _dbContext.Experiments.Add(experiment);
                _dbContext.SaveChanges();
            }

        }

        private IQueryable<Experiment> IncludeAll()
        {
            return _dbContext.Experiments.Include(p => p.Innovation).Include(s => s.User);
        }
    }
}
