using System;
using BallOfMud.Services;

namespace BallOfMud
{
    class Program
    {
        static void Main(string[] args)
        {
            BigClass bigClass = new BigClass();
            
            bigClass.SetValue(3);
            bigClass.IncrementI();
            bigClass.IncrementI();
            bigClass.IncrementI();
            
            bigClass.Decrememnt();

            Console.WriteLine($"Final Number : {bigClass.GetValueA()}");
        }
    }
}