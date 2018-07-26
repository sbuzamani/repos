﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public class CalculationStrategy
    {
        private int _target;  
        public CalculationStrategy(int target)
        {
            _target = target; 

        }
        public int Calculate(int value)
        {
            if (value < 0)
            {
                throw new Exception("value cannot be less than 0"); 
            }

            if (value > _target )
            {
                throw new Exception($"value cannot be greater than {_target}");
            }

            return _target - value;
        }
    }
}
