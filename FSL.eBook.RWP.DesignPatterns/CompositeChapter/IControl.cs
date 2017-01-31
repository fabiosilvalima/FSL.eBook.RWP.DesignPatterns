using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.CompositeChapter
{
    public interface IControl
    {
        int Id { get; set; }
        string Render();
    }
}