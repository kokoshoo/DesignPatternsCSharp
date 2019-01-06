using System;
namespace DesignPatternsCSharp.Strategy.BreakBehavior
{
    public class DismantleBehavior : IBreakBehavior
    {
        public void Break()
        {
            Console.WriteLine("Dismantles as if no screws were used in construction");
        }
    }
}
