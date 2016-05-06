using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsDecorator.Pizzas
{
    public class PizzaMeat: Pizza
    {
        public PizzaMeat() : base("Pizza with meat") { }

        public override decimal GetCost()
        {
            return 10;
        }
    }
}
