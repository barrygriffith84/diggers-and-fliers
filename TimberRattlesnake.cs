using System;

namespace diggers_and_fliers
{
    public class TimberRattlesnake : Animal, IWalker
    {
       
        public int landSpeed { get; set; }

        public void walk()
        {
            Console.WriteLine($"{Name} slithers around.  The {Species} contemplates its existence.  It ponders if conscious thought is a mistake of Mother Nature.");
        }
    }
}