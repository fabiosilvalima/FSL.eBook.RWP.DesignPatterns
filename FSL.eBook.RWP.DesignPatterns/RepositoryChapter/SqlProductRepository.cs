using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.RepositoryChapter
{
    public class SqlProductRepository : SqlRepository, IProductRepository
    {
        public void Insert(Product product)
        {

        }
    }
}