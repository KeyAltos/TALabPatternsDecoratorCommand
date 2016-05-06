using HomeTaskPatternsCommandDecorator.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsCommandDecorator.Commands
{
    public class PrimeNumberCommand : ICommand
    {
        PrimeNumber primeNumber;

        public PrimeNumberCommand(PrimeNumber primeNumber)
        {
            this.primeNumber = primeNumber;
        }
        public void Execute()
        {
            primeNumber.IsNumberPrime();
        }
    }    
}
