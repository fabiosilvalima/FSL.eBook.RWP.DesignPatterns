using Ninject.Modules;

namespace FSL.eBook.RWP.DesignPatterns.UnitOfWorkChapter.Scenario1
{
    public class UnitOfWorkModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRegisterUnitOfWork>().To<RegisterUnitOfWork>();
        }
    }
}