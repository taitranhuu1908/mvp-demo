using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.View
{
    public interface ICalculator
    {
        string TxtNumberOne { get; set; }
        string TxtNumberTwo { get; set; }
        string TxtResult { get; set; }
    }
}
