using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsDecorator
{
    public abstract class Pizza
    {
        public Pizza(string n)
        {
            this.name = n;
        }
        public string Name { get { return name; } }
        protected string name;

        public abstract decimal GetCost();

        public override string ToString()
        {
            return name +", "+ GetCost().ToString("C");
        }
    }
}
