﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyCalculator
{
    public class Operation
    {
        private double _numberA = 0;

        private double _numberB = 0;

        public double NumberA
        { get; set; }

        public double NumberB
        { get; set; }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
