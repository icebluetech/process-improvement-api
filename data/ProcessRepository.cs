using idata;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data
{
    public class ProcessRepository : IProcessRepository
    {
        private readonly ProcessImprovementContext _dbContext;
        public ProcessRepository(ProcessImprovementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Process> List()
        {
            return _dbContext.Processes;
        }

        public IEnumerable<Process> Search(string term)
        {
            if (term != null)
            {
                //return Mocks.UserList().Where(u => u.Name.ToLower().Contains(term.ToLower()));
    return List().Where(u => u.Name.ToLower().Contains(term.ToLower()));
            }

            return List();
        }

        public void Insert(Process process)
        {
            using (_dbContext)
            {
                _dbContext.Processes.Add(process);
                _dbContext.SaveChanges();
            }

        }
    }
}
