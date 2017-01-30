using FSL.eBook.RWP.DesignPatterns.RepositoryChapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSL.eBook.RWP.DesignPatterns.LazyLoadingChapter
{
    public class ProductService
    {
        private IProductRepository _productRepository;
        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = DependencyResolver.Current.GetService<IProductRepository>();
                }

                return _productRepository;
            }
        }
    }
}