using System;

namespace diggers_and_fliers
{
    public class Terrapin : Animal, IWalker
    {
       
        public int landSpeed { get; set; }

        public void walk()
        {
            Console.WriteLine($"{Name} slowly paces about.  The {Species} contemplates its existence.  It ponders if conscious thought is a mistake of Mother Nature.");
        }
    }
}