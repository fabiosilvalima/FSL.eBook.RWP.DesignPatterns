using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FSL.eBook.RWP.DesignPatterns.DecoratorChapter
{
    public class PizzaController : Controller
    {
        public ActionResult Index()
        {
            var pizza = new LargePizza();// large pizza
            var cheese = new CheeseDecorator(pizza); //large pizza with cheese
            var tomato = new TomatoDecorator(cheese); //large pizza with cheese and tomato

            return Content($"Decorator Pattern Pizza: {tomato.GetDescription()} - {tomato.CalculateCost()}");
        }
    }
}