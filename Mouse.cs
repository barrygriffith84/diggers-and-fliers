using System;

namespace diggers_and_fliers
{
    public class Mouse : Animal, IWalker, IDigger
    {
       
        public int landSpeed { get; set; }
        public string requiredBedding { get; set; }

        public void dig()
        {
            Console.WriteLine($"{Name} burrows into its {requiredBedding}.  It hides from its own thoughts.");
        }

        public void walk()
        {
            Console.WriteLine($"{Name} scurries in circles.  The {Species} wonders if it will ever escape this container.  The {Species} wonders if it has always been in this container.  It scurries to forget.");
        }
    }
}