using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSL.eBook.RWP.DesignPatterns.RepositoryChapter
{
    public interface IEntityRepository<TModel>
    {
        void Insert(TModel model);
    }
}
