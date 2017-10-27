using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyCalculator
{
    public  class OperationFactory
    {
        public static Operation createOperates(string operate)
        {
            Operation oper = null;

            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
            }

            return oper;
             
        }
    }
}
