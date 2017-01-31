using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.SingletonChapter
{
    public class SingletonModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILog>().To<DatabaseLog>();
        }
    }
}