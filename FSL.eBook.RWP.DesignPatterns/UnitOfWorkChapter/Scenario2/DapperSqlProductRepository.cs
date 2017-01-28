
namespace FSL.eBook.RWP.DesignPatterns.UnitOfWorkChapter.Scenario2
{
    public class DapperSqlProductRepository : RepositoryChapter.DapperSqlRepository<Product>, IProductRepository
    {
        public DapperSqlProductRepository()
        {
            TableName = "Product";
        }
    }
}