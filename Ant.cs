using System;

namespace diggers_and_fliers
{
    public class Ant : Animal, IWalker, IDigger
    {
       
        public int landSpeed { get; set; }
        public string requiredBedding { get; set; }

        public void dig()
        {
            Console.WriteLine($"{Name} digs furiously.  For the {Species} work is life.");
        }

        public void walk()
        {
            Console.WriteLine($"{Name} slowly paces about.  The {Species} contemplates its existence.  It ponders if conscious thought is a mistake of Mother Nature.");
        }
    }
}