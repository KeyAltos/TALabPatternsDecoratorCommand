using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsCommandDecorator.Recievers
{
    public class SumOfSymbolsInNumber
    {
        private int number;

        public SumOfSymbolsInNumber(int number)
        {
            this.number = number;
        }

        public void CalculateSum()
        {
            Console.Write("The sum of symbols in {0} is ", number);
            var sum = 0;
            do
            {
                sum += number % 10;
                number /= 10;

            } while (number > 0);
            Console.WriteLine(sum);
        }

    }
}
