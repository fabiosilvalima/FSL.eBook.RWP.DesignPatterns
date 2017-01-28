namespace FSL.eBook.RWP.DesignPatterns.UnitOfWorkChapter.Scenario2
{
    public class Payment : IEntity
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? ProductId { get; internal set; }

        public void Insert()
        {
            // same logic of product model
        }
    }
}