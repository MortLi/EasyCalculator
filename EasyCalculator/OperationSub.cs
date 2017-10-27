using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyCalculator
{
    public class OperationSub:Operation
    {
        public override double GetResult()
        {
            double result;
            result = NumberA + NumberB;
            return result;
        }
    }
}
