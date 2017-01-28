
namespace FSL.eBook.RWP.DesignPatterns.RepositoryChapter
{
    public class DapperSqlProductRepository : DapperSqlRepository<Product>, IProductRepository
    {
        public DapperSqlProductRepository()
        {
            TableName = "Product";
        }
    }
}