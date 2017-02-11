using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSL.eBook.RWP.DesignPatterns.ChainChapter
{
    public class ChainController : Controller
    {
        public ActionResult Index()
        {
            var seller = new Seller("Fabio", 30);
            var localManager = new Seller("Fabiana", 50);
            var regionalManager = new Seller("Thomas", 70);

            seller.SetSuperior(localManager);
            localManager.SetSuperior(regionalManager);

            var result = seller.ApplyDiscount(40);
            if (result.Approved)
            {
                var message = $"Seller {result.SellerName} approved {result.Value}!";
            }

            return Content("Chain");
        }
    }
}