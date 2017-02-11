
using System.Collections.Generic;

namespace FSL.eBook.RWP.DesignPatterns.StrategyChapter
{
    public class Context
    {
        private ISortStrategy _sortStrategy;

        public Context(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public List<string> Sort(List<string> list)
        {
            _sortStrategy.Sort(list);

            return list;
        }
    }
}