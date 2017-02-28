using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.FlyweightChapter
{
    public class Text : Control
    {
        public Text()
        {
            Tag = Tags.Text;
        }

        public override string Create(string text)
        {
            return $"<input type='text' value='{text}' /> => {text}";
        }
    }
}