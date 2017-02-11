
using System.Collections.Generic;
using System.Linq;

namespace FSL.eBook.RWP.DesignPatterns.StrategyChapter
{
    public class AscendingSortStrategy : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list = list.OrderBy(x => x).ToList();
        }
    }
}