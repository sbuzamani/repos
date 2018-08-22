using Practice.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Common
{
    public class DisplayStrategy:IDisplayStrategy
    {
        public void Display(int answer)
        {
            Console.Write($"The difference is {answer}");
        }

        public void Display(Exception exception)
        {
            Console.Write($"ERROR: {exception.Message}");
        }
    }
}
