
namespace FSL.eBook.RWP.DesignPatterns.UnitOfWorkChapter.Scenario1
{
    public class Payment
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? ProductId { get; internal set; }
    }
}