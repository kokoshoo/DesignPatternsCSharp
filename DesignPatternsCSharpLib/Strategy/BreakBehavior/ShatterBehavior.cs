using System;
namespace DesignPatternsCSharp.Strategy.BreakBehavior
{
    public class ShatterBehavior : IBreakBehavior
    {
        public void Break()
        {
            Console.WriteLine("Shatters to dust");
        }
    }
}
