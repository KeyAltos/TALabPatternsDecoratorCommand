using HomeTaskPatternsCommandDecorator.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsCommandDecorator.Commands
{
    public class SumOfSymbolsInNumberCommand: ICommand
    {
        SumOfSymbolsInNumber sumOfSimbolsInNumber;

        public SumOfSymbolsInNumberCommand(SumOfSymbolsInNumber sumOfSimbolsInNumber)
        {
            this.sumOfSimbolsInNumber = sumOfSimbolsInNumber;
        }

        public void Execute()
        {
            sumOfSimbolsInNumber.CalculateSum();
        }
        
    }
}
