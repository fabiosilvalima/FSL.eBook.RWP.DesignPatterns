using System.Web.Mvc;

namespace FSL.eBook.RWP.DesignPatterns.UnitOfWorkChapter.Scenario2
{
    public class Product : IEntity
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        private readonly IProductRepository _repository;

        public Product(IProductRepository repository)
        {
            _repository = repository;
        }

        public Product() : this(DependencyResolver.Current.GetService<IProductRepository>())
        {

        }
        
        public void Insert()
        {
            _repository.Insert(this);
        }
    }
}