using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.DecoratorChapter
{
    public class Tomato : PizzaDecorator
    {
        public Tomato(Pizza pizza) : base(pizza)
        {
            Description = "Tomato";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 0.25;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, {Description}";
        }
    }
}