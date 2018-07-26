using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {

           

            int target = 10;
       
            InputStrategy inputStrategy = new InputStrategy(target);

            CalculationStrategy calculationStrategy = new CalculationStrategy(target);

            DisplayStrategy displayStrategy = new DisplayStrategy();

            new App(inputStrategy, calculationStrategy, displayStrategy).Run();

            Console.ReadLine();
        }
    }
}
