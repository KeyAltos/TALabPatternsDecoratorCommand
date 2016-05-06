using HomeTaskPatternsDecorator.Components;
using HomeTaskPatternsDecorator.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskPatternsDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region choosing Pizza
            int kindOfPizza, numberOfComponents;
            Console.WriteLine("Hello, my friend, glad to see you. Please choose your favorite pizza for order:");
            Console.WriteLine("1. Cheese Pizza\n2. Meat Pizza\n3. Vegan Pizza");
            ParseConsoleLineToIntAndCheckDiapason(out kindOfPizza, 0, 3);

            Pizza pizzaForOrder=null;
            switch (kindOfPizza)
            {
                case 1:
                    pizzaForOrder = new PizzaCheese();
                    break;
                case 2:
                    pizzaForOrder = new PizzaMeat();
                    break;
                case 3:
                    pizzaForOrder = new PizzaVegan();
                    break;

                default:
                    break;
            }
            #endregion

            #region choosing components
            Console.Clear();
            Console.WriteLine("You choosed {0}", pizzaForOrder);
            Console.WriteLine();

            var componentsNames = new List<string>() { "mushrooms", "pepperoni", "pepper" };
            var totalNumberOfComponents = 0;
            foreach (var component in componentsNames)
            {
                Console.WriteLine("Would you like adding some {0}? Enter a number for component (max 5)", component);
                Console.WriteLine("If you wouldn't this component, please enter 0");
                ParseConsoleLineToIntAndCheckDiapason(out numberOfComponents, 0, 5);  

                for (int i = 0; i < numberOfComponents; i++)
                {
                    switch (component)
                    {
                        case "mushrooms":
                            pizzaForOrder = new ComponentMushrooms(pizzaForOrder);
                            break;
                        case "pepperoni":
                            pizzaForOrder = new ComponentPepperonies(pizzaForOrder);
                            break;
                        case "pepper":
                            pizzaForOrder = new ComponentPeppers(pizzaForOrder);
                            break;

                        default:
                            break;
                    }
                }
                totalNumberOfComponents += numberOfComponents;
            }
            #endregion

            #region cost and discount
            Console.Clear();
            Console.WriteLine("You finaly order is:");
            Console.WriteLine(pizzaForOrder);
            
            if (totalNumberOfComponents>1)
            {
                Console.WriteLine("You have a discount 5%, you finaly price is: {0:C}", pizzaForOrder.GetCost()*0.95M);
            }




            Console.ReadKey();
            
        }
        #endregion

        private static void ParseConsoleLineToIntAndCheckDiapason(out int value, int lowLimitValue,int maxLimitValue)
        {
            while (!Int32.TryParse(Console.ReadLine(), out value) || value < lowLimitValue || value > maxLimitValue)
            {
                Console.WriteLine("Please enter correct number from {0} to {1}", lowLimitValue, maxLimitValue);
            }
        }
    }
}
