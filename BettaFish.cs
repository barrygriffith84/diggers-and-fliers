using System;

namespace diggers_and_fliers
{
    public class BettaFish : Animal, ISwimmer
    {
        public int maximumDepth { get; set; }

        public void swim()
        {
            Console.WriteLine($"{Name} swims around the tank.  As Sisyphus and the rock, it repeats the same routine every hour of every day.  It waits for blessings from the Food God.");
        }
    }
}