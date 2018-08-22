using Practice.Common.Interfaces;
using Practice.Common;
using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 10;
       
            IInputStrategy inputStrategy = new ConsoleInputStrategy(target);

            ICalculationStrategy calculationStrategy = new CalculationStrategy(target);

            IDisplayStrategy displayStrategy = new DisplayStrategy();

            new App(inputStrategy, calculationStrategy, displayStrategy).Run();

            Console.ReadLine();
        }
    }
}
