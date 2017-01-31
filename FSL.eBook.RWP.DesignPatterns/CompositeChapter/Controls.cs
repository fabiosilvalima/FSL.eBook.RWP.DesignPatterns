using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.CompositeChapter
{
    public class Controls : List<IControl>, IControl
    {
        public int Id { get; set; }

        public string Render()
        {
            var sb = new StringBuilder();
            foreach(var control in this)
            {
                sb.Append($"{Id} : control: {control.Render()}</br>");
            }

            return sb.ToString();
        }
    }
}