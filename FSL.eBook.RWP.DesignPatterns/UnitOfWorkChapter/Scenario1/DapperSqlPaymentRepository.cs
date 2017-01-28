using FSL.eBook.RWP.DesignPatterns.RepositoryChapter;

namespace FSL.eBook.RWP.DesignPatterns.UnitOfWorkChapter.Scenario1
{
    public class DapperSqlPaymentRepository : DapperSqlRepository<Payment>, IPaymentRepository
    {
        public DapperSqlPaymentRepository()
        {
            TableName = "Payment";
        }
    }
}