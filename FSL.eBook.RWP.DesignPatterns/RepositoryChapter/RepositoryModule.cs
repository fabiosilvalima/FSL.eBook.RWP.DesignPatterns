using Ninject.Modules;

namespace FSL.eBook.RWP.DesignPatterns.RepositoryChapter
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductRepository>().To<DapperSqlProductRepository>();
        }
    }
}