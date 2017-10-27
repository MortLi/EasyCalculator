using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Operation oper;
                Console.WriteLine("Please enter number A：");
                double numberA = Convert.ToDouble(Console.ReadLine().Trim());

                Console.WriteLine("Please choose a operater（+ - * /）：");
                string operate = Console.ReadLine().Trim();

                Console.WriteLine("Please enter number B：");
                double numberB = Convert.ToDouble(Console.ReadLine().Trim());

                oper = OperationFactory.createOperates(operate);
                oper.NumberA = numberA;
                oper.NumberB = numberB;

                double result = oper.GetResult();
                Console.WriteLine("The result is {0}", result.ToString());
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Your input is incorrect："+ex.Message);
                Console.ReadLine();
            }
        }
    }
}
