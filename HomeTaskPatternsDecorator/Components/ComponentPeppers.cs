using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsDecorator.Components
{
    public class ComponentPeppers : Component
    {
        public ComponentPeppers(Pizza p) 
        : base(p.Name + ", with pepper", p)
    { }

        public override decimal GetCost()
        {
            return pizza.GetCost() + 2;
        }
    }
}
