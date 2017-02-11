using System.Collections.Generic;
using System.Web.Mvc;

namespace FSL.eBook.RWP.DesignPatterns.StrategyChapter
{
    public class StrategyController : Controller
    {
        public ActionResult Index()
        {
            var list = new List<string>()
            {
                "fabio",
                "silva",
                "lima"
            };

            var product = new Context(new DescendingSortStrategy());
            product.Sort(list);
            product = new Context(new AscendingSortStrategy());
            product.Sort(list);
            product = new Context(new BubleSortStrategy());
            product.Sort(list);

            return Content("Strategy");
        }
    }
}