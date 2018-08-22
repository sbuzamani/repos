using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Common.Interfaces
{
    public interface IDisplayStrategy
    {
        void Display(int target);
        void Display(Exception exception);
    }
}
