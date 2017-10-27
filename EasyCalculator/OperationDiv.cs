using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyCalculator
{
    public class OperationDiv:Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
            {
                throw new Exception("Cannot divide by zero");
            }
            result = NumberA / NumberB;
            return result;
        }
    }
}
