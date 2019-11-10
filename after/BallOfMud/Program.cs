using System;
using BallOfMud.Services;

namespace BallOfMud
{
    class Program
    {
        static void Main(string[] args)
        {
            BigClassFacade bigClass = new BigClassFacade();
            
            bigClass.Incrememnt();
            bigClass.Incrememnt();
            bigClass.Incrememnt();
            bigClass.Decrement();
            
            Console.WriteLine($"Final Number : {bigClass.GetCurrentValue()}");
        }
    }
}