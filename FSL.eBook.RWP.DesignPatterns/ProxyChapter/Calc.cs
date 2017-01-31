using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.ProxyChapter
{
    public class Calc : ICalc
    {
        public string Message { get; set; }

        public double Calculate()
        {
            Message = "Calculated!";

            return 32 * 9;
        }
    }
}