
using System;

namespace FSL.eBook.RWP.DesignPatterns.FacadeChapter
{
    public class SecurityInfo : IDisposable
    {
        public void Dispose()
        {

        }

        public string GetFromUserId(string userId)
        {
            return "ID232R54";
        }
    }
}