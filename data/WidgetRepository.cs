using idata;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data
{
    public class WidgetRepository : IWidgetRepository
    {
        private readonly ProcessImprovementContext _dbContext;
        public WidgetRepository(ProcessImprovementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Widget> List()
        {
            return _dbContext.Widgets;
        }

        public IEnumerable<Widget> Search(string term)
        {
            if (term != null)
            {
                //return Mocks.UserList().Where(u => u.Name.ToLower().Contains(term.ToLower()));
    return List().Where(u => u.Name.ToLower().Contains(term.ToLower()));
            }

            return List();
        }

        public void Insert(Widget widget)
        {
            using (_dbContext)
            {
                _dbContext.Widgets.Add(widget);
                _dbContext.SaveChanges();
            }

        }
    }
}
