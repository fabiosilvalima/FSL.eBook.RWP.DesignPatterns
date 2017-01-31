using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.SingletonChapter
{
    public interface ILog
    {
        void LogException(Exception ex);
    }
}