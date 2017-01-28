using System.Collections.Generic;

namespace FSL.eBook.RWP.DesignPatterns.UnitOfWorkChapter.Scenario2
{
    public class UnitOfWork : IUnitOfWork
    {
        private List<IEntity> _entities;

        public UnitOfWork()
        {
            _entities = new List<IEntity>();
        }

        public void Add(IEntity entity)
        {
            _entities.Add(entity);
        }

        public void Commit()
        {
            _entities.ForEach(x => x.Insert());
        }
    }
}