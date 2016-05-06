using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsDecorator.Pizzas
{
    public class PizzaVegan : Pizza
    {
        public PizzaVegan() : base("Pizza without meat") { }

        public override decimal GetCost()
        {
            return 5;
        }
    }
}
