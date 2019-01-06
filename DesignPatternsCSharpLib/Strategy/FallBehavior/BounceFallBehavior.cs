using System;
namespace DesignPatternsCSharp.Strategy
{
    public class BounceFallBehavior : IFallBehavior
    {
        public void Fall()
        {
            Console.WriteLine("Bounces away");
        }
    }
}
