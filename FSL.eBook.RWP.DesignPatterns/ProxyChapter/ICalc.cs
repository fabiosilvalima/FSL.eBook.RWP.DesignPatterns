using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.ProxyChapter
{
    public interface ICalc
    {
        double Calculate();
        string Message { get; set; }
    }
}