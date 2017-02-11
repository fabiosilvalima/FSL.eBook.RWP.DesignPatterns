
using System;

namespace FSL.eBook.RWP.DesignPatterns.FacadeChapter
{
    public class Payment : IDisposable
    {
        public void Dispose()
        {

        }

        public bool Pay(string id, double amount)
        {
            return true;
        }
    }
}