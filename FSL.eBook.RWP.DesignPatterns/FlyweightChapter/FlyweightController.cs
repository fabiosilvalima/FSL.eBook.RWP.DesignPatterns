using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSL.eBook.RWP.DesignPatterns.FlyweightChapter
{
    public class FlyweightController : Controller
    {
        public ActionResult Index(int id = 100)
        {
            int[] tagsIds = new[] { 10, 20, 30, 50, 100, 150, 200, 250, 260, 270, 300, 350, 400, 500, 600, 700, 1000, 1050, 1200 };
            var factory = new ControlFactory();
            int sum = 0;
            var rnd = new Random();
            while (sum <= id)
            {
                Control graphicalMoneyObj = null;
                var tag = Tags.Text;
                int tagId = tagsIds[rnd.Next(0, tagsIds.Length)];
                if (tagId >= 0 && tagId <= 100)
                {
                    tag = Tags.Button;
                }
                if (tagId >= 101 && tagId <= 300)
                {
                    tag = Tags.Radio;
                }
                graphicalMoneyObj = factory.GetControl(tag);
                sum++;
            }

            return Content("Flyweight");
        }
    }
}