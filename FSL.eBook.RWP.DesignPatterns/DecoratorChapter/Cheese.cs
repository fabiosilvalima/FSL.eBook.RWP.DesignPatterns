using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.DecoratorChapter
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza) : base(pizza)
        {
            Description = "Cheese";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 1.25;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, {Description}";
        }
    }
}