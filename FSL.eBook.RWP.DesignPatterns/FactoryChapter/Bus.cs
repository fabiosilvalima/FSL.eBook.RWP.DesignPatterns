
namespace FSL.eBook.RWP.DesignPatterns.FactoryChapter
{
    public class Bus : ITransport
    {
        public string Build()
        {
            return "Bus transport";
        }
    }
}