using System.Web.Mvc;

namespace FSL.eBook.RWP.DesignPatterns.RepositoryChapter
{
    public class RepositoryDefaultController : Controller
    {
        public ActionResult Index()
        {
            var productRepository = new DapperSqlProductRepository();
            var product = new Product()
            {
                Id = 100,
                Name = "Product 100"
            };

            productRepository.InsertProduct(product);

            return View();
        }
    }
}