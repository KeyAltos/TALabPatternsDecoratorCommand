using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsCommandDecorator.Recievers
{
    public class PrimeNumber
    {
        private int number;

        public PrimeNumber(int number)
        {
            this.number = number;
        }

        public void IsNumberPrime()
        {
            if (isNumberPrime())
            {
                Console.WriteLine("{0} is prime",number);
            }
            else
            {
                Console.WriteLine("{0} is composite", number);
            }
        }

        private bool isNumberPrime()
        {

            if (number == 1) return false;
            if (number == 2) return true;

            if (number % 2 == 0) return false;      

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
