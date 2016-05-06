using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsDecorator.Pizzas
{
    public class PizzaCheese: Pizza
    {
        public PizzaCheese() : base("Pizza with cheese") { }

        public override decimal GetCost()
        {
            return 8;
        }
    }
}
