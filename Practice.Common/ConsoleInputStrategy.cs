using Practice.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Common
{
    public class ConsoleInputStrategy : IInputStrategy
    {
        protected int _target;

        public ConsoleInputStrategy(int target)
        {
            _target = target;
        }

        public int GetValue()
        {
            Console.WriteLine($"Enter number less than {_target}: ");

            string input = Console.ReadLine();
            if (!int.TryParse(input, out int result))
            {
                throw new Exception("...");
            }

            return result;
        }
    }
}
