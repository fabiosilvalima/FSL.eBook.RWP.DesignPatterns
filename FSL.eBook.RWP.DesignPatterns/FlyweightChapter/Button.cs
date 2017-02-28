using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.FlyweightChapter
{
    public class Button : Control
    {
        public Button()
        {
            Tag = Tags.Button;
        }

        public override string Create(string text)
        {
            return $"<input type='button' value='{text}' /> => {text}";
        }
    }
}