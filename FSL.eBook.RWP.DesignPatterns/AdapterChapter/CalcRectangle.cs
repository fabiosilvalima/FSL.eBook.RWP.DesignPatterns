using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.AdapterChapter
{
    public sealed class CalcRectangle
    {
        public int CalculateArea(Rectangle rectangle)
        {
            int area = (rectangle.Width * rectangle.Height);

            return area;
        }
    }
}