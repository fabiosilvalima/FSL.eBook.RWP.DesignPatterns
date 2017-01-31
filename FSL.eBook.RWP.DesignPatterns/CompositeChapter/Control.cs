using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.CompositeChapter
{
    public class Control : IControl
    {
        public int Id { get; set; }

        public string Render()
        {
            return $"control {Id}";
        }
    }
}