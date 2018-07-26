using Practice1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public class ConsoleInputStrategy : IInputStrategy
    {
        private int _target;

        public ConsoleInputStrategy(int target)
        {
            _target = target;
        }

        public int GetValue()
        {
            Console.WriteLine($"Enter number less than {_target}: ");

            string input = Console.ReadLine();

            return int.Parse(input);
        }
    }
}
