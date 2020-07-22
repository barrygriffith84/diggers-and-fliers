using System;

namespace diggers_and_fliers
{
    public class Gerbil : Animal, IDigger, IWalker
    {
        public string requiredBedding { get; set; }
        public int landSpeed { get; set; }

        public void dig()
        {
            Console.WriteLine($"{Name} burrows into its {requiredBedding}.  It hides from its own thoughts.");
        }

        public void walk()
        {
            Console.WriteLine($"{Name} runs sporadically.  It plots its revenge.");
        }
    }
}