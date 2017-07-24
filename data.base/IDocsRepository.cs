using model;
using System;
using System.Threading.Tasks;

namespace idata
{
    public interface IDocsRepository
    {
        void Upload(Doc doc);

        void Save(Doc doc);
    }
}
