using HomeTaskPatternsCommandDecorator.Commands;
using HomeTaskPatternsCommandDecorator.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeTaskPatternsCommandDecorator
{
    class Program
    {
        static void Main(string[] args)
        {            

            int typeOfCommand;
            var invoker = new Invoker();
            ICommand command = null;
            int numberForOperation;

            do
            {
                Console.Clear();
                Console.WriteLine("Please choose what do you want:");
                Console.WriteLine("1. Check is number prime\n2. Calculate sum of symbols in number\n3. Calculate distance between 2 points");
                Console.WriteLine();

                ParseConsoleLineToIntAndCheckDiapason(out typeOfCommand, 0, 3);

                switch (typeOfCommand)
                {
                    case 1:
                        ParseConsoleLineToIntAndCheckDiapason(out numberForOperation, Int32.MinValue, Int32.MaxValue);
                        command = new PrimeNumberCommand(new PrimeNumber(numberForOperation));
                        break;
                    
                    case 2:
                        ParseConsoleLineToIntAndCheckDiapason(out numberForOperation, Int32.MinValue, Int32.MaxValue);
                        command = new SumOfSymbolsInNumberCommand(new SumOfSymbolsInNumber(numberForOperation));
                        break;

                    case 3:
                        Console.WriteLine("Point one");
                        var pointOne = InitializatePointFromConsole();
                        Console.WriteLine();

                        Console.WriteLine("Point two");
                        var pointTwo = InitializatePointFromConsole();
                        Console.WriteLine();
                        command = new TwoPointsDistanceCommand(new TwoPointsDistance(pointOne, pointTwo));
                        break;

                    default:
                        break;
                }
                command.Execute();
                Console.WriteLine();
                Console.WriteLine("For quit press 'q', for repeat any other button");
            } while (Console.ReadLine()!="q");
        }
        

        private static void ParseConsoleLineToIntAndCheckDiapason(out int value, int lowLimitValue, int maxLimitValue)
        {
            while (!Int32.TryParse(Console.ReadLine(), out value) || value < lowLimitValue || value > maxLimitValue)
            {
                Console.WriteLine("Please enter correct number from {0} to {1}", lowLimitValue, maxLimitValue);
            }
        }

        private static Point InitializatePointFromConsole()
        {
            //code dublicate
            int x, y;
            do
            {
                Console.WriteLine("Please enter the value for x coordinate of point");
            }
            while (!Int32.TryParse(Console.ReadLine(), out x));
            do
            {
                Console.WriteLine("Please enter the value for y coordinate of point");
            }
            while (!Int32.TryParse(Console.ReadLine(), out y));
            return new Point(x, y);

        }
    }


}

