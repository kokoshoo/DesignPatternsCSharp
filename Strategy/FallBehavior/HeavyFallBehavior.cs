using System;
namespace DesignPatternsCSharp.Strategy
{
    public class HeavyFallBehavior : IFallBehavior
    {
        public void Fall()
        {
            Console.WriteLine("Thud");
        }
    }
}
