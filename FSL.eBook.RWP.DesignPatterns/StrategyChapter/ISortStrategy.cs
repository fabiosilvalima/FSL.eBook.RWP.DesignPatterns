
using System.Collections.Generic;

namespace FSL.eBook.RWP.DesignPatterns.StrategyChapter
{
    public interface ISortStrategy
    {
        void Sort(List<string> list);
    }
}