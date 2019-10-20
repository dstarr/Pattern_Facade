using System;
using GenericFacade.Services;

namespace GenericFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceA = new ServiceA();
            serviceA.Method1();
            
            var serviceB = new ServiceB();
            string serviceBString = serviceB.Method2();
            
            var serviceC = new ServiceC();
            string serviceCString = serviceC.Method2();
            
            Console.WriteLine($"{serviceBString} - {serviceCString}");
        }
    }
}