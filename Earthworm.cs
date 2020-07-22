using System;

namespace diggers_and_fliers
{
    public class Earthworm : Animal, IDigger
    {
        public string requiredBedding { get; set; }

        public void dig()
        {
            Console.WriteLine($"{Name} burrows into its {requiredBedding}.  It hides from its own thoughts.");
        }
    }
}