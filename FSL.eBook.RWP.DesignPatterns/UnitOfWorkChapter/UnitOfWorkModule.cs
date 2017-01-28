using Ninject.Modules;

namespace FSL.eBook.RWP.DesignPatterns.UnitOfWorkChapter
{
    public class UnitOfWorkModule : NinjectModule
    {
        public override void Load()
        {
            Bind<Scenario1.IRegisterUnitOfWork>().To<Scenario1.RegisterUnitOfWork>();
            Bind<Scenario2.IProductRepository>().To<Scenario2.DapperSqlProductRepository>();
            Bind<Scenario2.IUnitOfWork>().To<Scenario2.UnitOfWork>();
        }
    }
}