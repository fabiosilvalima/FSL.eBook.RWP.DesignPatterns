
using System.Collections.Generic;
using System.Linq;

namespace FSL.eBook.RWP.DesignPatterns.StrategyChapter
{
    public class DescendingSortStrategy : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list = list.OrderByDescending(x => x).ToList();
        }
    }
}