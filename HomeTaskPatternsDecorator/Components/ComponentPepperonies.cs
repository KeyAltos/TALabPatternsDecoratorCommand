using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsDecorator.Components
{
    public class ComponentPepperonies : Component
    {
        public ComponentPepperonies(Pizza p) 
        : base(p.Name + ", with pepperoni", p)
    { }

        public override decimal GetCost()
        {
            return pizza.GetCost() + 4;
        }
    }
}
