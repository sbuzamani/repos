using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public class DisplayStrategy
    {
        public void Display(int answer)
        {
            Console.WriteLine($"The difference is {answer}");
        }

        public void Display(Exception exception)
        {
            Console.WriteLine($"ERROR: {exception.Message}");
        }
    }
}
