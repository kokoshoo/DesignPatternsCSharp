using System;
namespace DesignPatternsCSharp.Strategy.SoundBehavior
{
    public class SqueakBehavior : ISoundBehavior
    {
        public void MakeNoise()
        {
            Console.WriteLine("Lets out an ear piercing squeak");
        }
    }
}
