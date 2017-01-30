using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSL.eBook.RWP.DesignPatterns.AdapterChapter
{
    public class AdapterController : Controller
    {
        public ActionResult Index()
        {
            var square = new Square() { Size = 50 };
            var calc = new CalcAdapter();
            var area = calc.CalculateArea(square);

            return View($"ADAPTER PATTERN AREA of square {square.Size}: {area}");
        }
    }
}