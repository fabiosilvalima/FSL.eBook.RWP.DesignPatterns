using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSL.eBook.RWP.DesignPatterns.SingletonChapter
{
    public class SingletonController : Controller
    {
        public ActionResult Index()
        {
            Log.Instance.LogException(new Exception("test"));

            return Content("Singleton"); 
        }
    }
}