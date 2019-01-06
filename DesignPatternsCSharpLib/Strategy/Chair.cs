using System;
namespace DesignPatternsCSharp.Strategy
{
    public class Chair
    {
        ISoundBehavior soundBehavior;
        IBreakBehavior breakBehavior;
        IFallBehavior fallBehavior;

        public Chair(ISoundBehavior sb, IBreakBehavior bb, IFallBehavior fb)
        {
            soundBehavior = sb;
            breakBehavior = bb;
            fallBehavior = fb;
        }

        public void Fall()
        {
            fallBehavior.Fall();
        }

        public void Break()
        {
            breakBehavior.Break();
        }

        public void MakeNoise()
        {
            soundBehavior.MakeNoise();
        }


    }
}
