using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.FlyweightChapter
{
    public class Radio : Control
    {
        public Radio()
        {
            Tag = Tags.Radio;
        }

        public override string Create(string text)
        {
            return $"<input type='radio' value='{text}' /> => {text}";
        }
    }
}