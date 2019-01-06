using System;
using DesignPatternsCSharp.Strategy;
using DesignPatternsCSharp.Strategy.BreakBehavior;
using DesignPatternsCSharp.Strategy.SoundBehavior;

namespace DesignPatternsInAction
{
    public class StrategyProgram
    {
        static void Main()
        {
            new Chair(new SqueakBehavior(), new DismantleBehavior(), new BounceFallBehavior())
            {
                Name = "Loud chair"
            }.StartActionSequence();

            new Chair(new BreakingSoundBehavior(), new ShatterBehavior(), new HeavyFallBehavior()).StartActionSequence();

            Console.ReadLine();
        }
    }
}
