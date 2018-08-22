using Practice.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public class App
    {
        private IInputStrategy _inputStrategy;
        private ICalculationStrategy _calculationStrategy;
        private IDisplayStrategy _displayStrategy;

        public App(IInputStrategy inputStrategy, ICalculationStrategy calculationStrategy, IDisplayStrategy displayStrategy)
        {
            _inputStrategy = inputStrategy;
            _calculationStrategy = calculationStrategy;
            _displayStrategy = displayStrategy;
        }

        public void Run()
        {
            try
            {
                int value = _inputStrategy.GetValue();

                int answer = _calculationStrategy.Calculate(value);

                _displayStrategy.Display(answer);

            }
            catch (Exception exception)
            {
                _displayStrategy.Display(exception);
            }
        }
    }
}
