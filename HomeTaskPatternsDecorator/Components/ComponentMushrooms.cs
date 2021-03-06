﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsDecorator.Components
{
    public class ComponentMushrooms: Component
    {
        public ComponentMushrooms(Pizza p) 
        : base(p.Name + ", with mushrooms", p)
    { }

        public override decimal GetCost()
        {
            return pizza.GetCost() + 3;
        }
    }
}
