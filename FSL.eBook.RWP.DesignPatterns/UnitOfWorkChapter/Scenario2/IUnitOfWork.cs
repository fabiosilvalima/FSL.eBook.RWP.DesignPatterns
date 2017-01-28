namespace FSL.eBook.RWP.DesignPatterns.UnitOfWorkChapter.Scenario2
{
    public interface IUnitOfWork
    {
        void Add(IEntity entity);

        void Commit();
    }
}
