using idata;
using Microsoft.EntityFrameworkCore;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data
{
    public class RootCauseAnalysisRepository : IRootCauseAnalysisRepository
    {
        private readonly ProcessImprovementContext _dbContext;
        public RootCauseAnalysisRepository(ProcessImprovementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<RootCauseAnalysis> List()
        {
            return IncludeAll();
        }

        public RootCauseAnalysis Get(int Id)
        {
            var all = IncludeAll();
            return all.Single(s => s.Id == Id);
        }

        public void Insert(RootCauseAnalysis rootCauseAnalysis)
        {
            using (_dbContext)
            {
                _dbContext.RootCauseAnalysies.Add(rootCauseAnalysis);
                _dbContext.SaveChanges();
            }

        }

        private IQueryable<RootCauseAnalysis> IncludeAll()
        {
            return _dbContext.RootCauseAnalysies.Include(s => s.User);
        }
    }
}
