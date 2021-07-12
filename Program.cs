using Study.OOPS.AbstractFactory;
using Study.OOPS.Adapter;
using Study.OOPS.Decorator;
using Study.OOPS.Facade;
using Study.OOPS.Observer;
using Study.OOPS.ObserverV1;
using Study.OOPS.Proxy;
using System;
using System.Threading.Tasks;

namespace Study.OOPS
{
    class Program
    {
        static async Task Main(string[] args)
        {            
            //DPFactoryMethod dPFactoryMethod = new DPFactoryMethod();
            //dPFactoryMethod.Main();
            //DPAbstractFactory dPAbstractFactory = new DPAbstractFactory();
            //dPAbstractFactory.Main();
            //DPAdapterMain dPAdapterMain = new DPAdapterMain();
            //dPAdapterMain.Main();
            //DPDecoratorMain _DPDecoratorMain = new DPDecoratorMain();
            //_DPDecoratorMain.Main();
            //DPFacadeMain dPFacadeMain = new DPFacadeMain();
            //dPFacadeMain.Main();
            //DPProxyMain dPProxyMain = new DPProxyMain();
            //dPProxyMain.Main();
            //DPObserverMain dPObserverMain = new DPObserverMain();
            //dPObserverMain.Main();
            DPObserverMainV1 dPObserverMain = new DPObserverMainV1();
            dPObserverMain.Main();
            Console.ReadKey();
        }
        
    }
}
