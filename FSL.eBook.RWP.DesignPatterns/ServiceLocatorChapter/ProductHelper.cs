using FSL.eBook.RWP.DesignPatterns.RepositoryChapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSL.eBook.RWP.DesignPatterns.ServiceLocatorChapter
{
    public static class ProductHelper
    {
        public static IProductRepository ProductRepository()
        {
            var repository = DependencyResolver.Current.GetService<IProductRepository>();

            if (repository == null)
            {
                repository = new DapperSqlProductRepository();
            }

            return repository;
        }
    }
}