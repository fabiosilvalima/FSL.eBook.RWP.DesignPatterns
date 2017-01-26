using Dapper;

namespace FSL.eBook.RWP.DesignPatterns.RepositoryChapter
{
    public class DapperSqlProductRepository : SqlRepository, IProductRepository
    {
        public DapperSqlProductRepository()
        {

        }

        public void InsertProduct(Product product)
        {
            var command = $"INSERT INTO Product (Id, Name) VALUES (@Id, @Name)";

            Database.Execute(command, product);
        }
    }
}