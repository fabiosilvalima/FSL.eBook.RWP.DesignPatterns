
namespace FSL.eBook.RWP.DesignPatterns.FactoryChapter
{
    public class Truck : ITransport
    {
        public string Build()
        {
            return "Truck transport";
        }
    }
}