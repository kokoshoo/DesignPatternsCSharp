using System;
namespace DesignPatternsCSharp.Strategy.SoundBehavior
{
    public class BreakingSoundBehavior : ISoundBehavior
    {
        public void MakeNoise()
        {
            Console.WriteLine("Lets out a sound as if something broke somewhere");
        }
    }
}
