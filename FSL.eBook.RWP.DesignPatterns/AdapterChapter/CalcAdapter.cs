using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.AdapterChapter
{
    public class CalcAdapter
    {
        public int CalculateArea(Square square)
        {
            if (square == null) return 0;

            var calcRectangle = new CalcRectangle();
            var rectangle = new Rectangle() { Width = square.Size, Height = square.Size };
            var area = calcRectangle.CalculateArea(rectangle);

            return area;
        }
    }
}