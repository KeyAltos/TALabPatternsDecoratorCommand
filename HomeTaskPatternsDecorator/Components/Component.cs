using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsDecorator.Components
{
    public abstract class Component : Pizza
    {
        protected Pizza pizza;
        public Component(string nameOfAddingComponent, Pizza pizza) : base(nameOfAddingComponent)
        {
            this.pizza = pizza;
        }
    }
}
