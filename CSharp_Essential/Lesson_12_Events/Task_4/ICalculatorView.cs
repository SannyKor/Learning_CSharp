using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    public interface ICalculatorView
    {
        double Value1 { get; }
        double Value2 { get; }
        double Result { set; }
        string Operation { get; }        
        event EventHandler CalcClick;
    }  
}
