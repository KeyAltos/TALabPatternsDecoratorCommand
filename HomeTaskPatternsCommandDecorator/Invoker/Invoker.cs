using HomeTaskPatternsCommandDecorator.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsCommandDecorator
{
    public class Invoker
    {
        ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void StartProccess()
        {
            command.Execute();
        }
    }

    
}
