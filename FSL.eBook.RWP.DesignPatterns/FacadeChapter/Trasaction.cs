using System;

namespace FSL.eBook.RWP.DesignPatterns.FacadeChapter
{
    public class Trasaction : IDisposable
    {
        private bool _transaction = false;

        public void Start()
        {
            _transaction = true;
        }

        public void Do(Action action)
        {
            action();
        }
        
        public void End()
        {
            _transaction = false;
        }

        public void Dispose()
        {

        }
    }
}