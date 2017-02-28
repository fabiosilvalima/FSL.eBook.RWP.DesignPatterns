
using System;

namespace FSL.eBook.RWP.DesignPatterns.FactoryChapter
{
    public static class TransportFactory
    {
        public static ITransport CreateInstance(string name)
        {
            return Activator.CreateInstance(Type.GetType($"FSL.eBook.RWP.DesignPatterns.FactoryChapter.{name}")) as ITransport;
        }
    }
}