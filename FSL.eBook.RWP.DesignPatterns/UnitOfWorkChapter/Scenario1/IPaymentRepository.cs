using FSL.eBook.RWP.DesignPatterns.RepositoryChapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FSL.eBook.RWP.DesignPatterns.UnitOfWorkChapter.Scenario1
{
    public interface IPaymentRepository : IEntityRepository<Payment>
    {

    }
}