using idata;
using model;
using System;
using System.Collections.Generic;
using System.Text;

namespace data
{
    public class DocsRepository : IDocsRepository
    {
        private readonly ProcessImprovementContext _dbContext;
        public DocsRepository(ProcessImprovementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Doc> List()
        {
            return _dbContext.Docs;
        }

        public void Upload(Doc doc)
        {
            //upload to file system
        }
    }
}
