using model;
using System;
using System.Collections.Generic;

namespace idata
{
    public interface IWidgetRepository
    {
        IEnumerable<Widget> List();
        IEnumerable<Widget> Search(string term);
        void Insert(Widget widget);
    }
}
