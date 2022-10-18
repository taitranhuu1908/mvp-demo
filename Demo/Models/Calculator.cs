using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Calculator
    {
        public double NumberOne { get; set; }
        public double NumberTwo { get; set; }

        public double Add()
        {
            return NumberOne + NumberTwo;
        }

        public double Subtract()
        {
            return NumberOne - NumberTwo;
        }

        public double Multiple()
        {
            return NumberOne * NumberTwo;
        }

        public double Diviton()
        {
            return NumberOne / NumberTwo;
        }
    }
}
