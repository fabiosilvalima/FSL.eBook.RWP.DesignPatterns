using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSL.eBook.RWP.DesignPatterns.CompositeChapter
{
    public class CompositeController : Controller
    {
        // GET: Composite
        public ActionResult Index()
        {
            var nodes = new Controls() { Id = 1 };
            nodes.Add(new Control() { Id = 2 });
            nodes.Add(new Control() { Id = 3 });
            IControl control = nodes;

            return Content($"Composite:</br> {control.Render()}");
        }
    }
}