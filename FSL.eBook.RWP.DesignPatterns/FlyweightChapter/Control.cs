using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.FlyweightChapter
{
    public enum Tags
    {
        Text = 1,
        Button = 2,
        Radio = 3
    }

    public abstract class Control 
    {
        public Tags Tag { get; set; }

        public abstract string Create(string text);
    }
}