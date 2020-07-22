using System;

namespace diggers_and_fliers
{
    class Program
    {
        static void Main(string[] args)
        {
            Parakeet bob = new Parakeet()
            {
                Name = "Bob",
                Color = "lime",
                Species = "Parakeet",
                maximumDistance = 20
            };

           

            Ant joe = new Ant()
            {
                Name = "Joe",
                Color = "red",
                Species = "Fire Ant",
                landSpeed = 1,
                requiredBedding = "dirt"
            };

            Earthworm jim = new Earthworm()
            {
                Name = "Jim",
                Color = "reddish brown",
                Species = "Nightcrawler",
                requiredBedding = "dirt"
            };

            Finch job = new Finch()
            {
                Name = "Job",
                Color = "grey",
                Species = "House Finch",
                maximumDistance = 20
            };

            Gerbil jack = new Gerbil()
            {
                Name = "Jack",
                Color = "beige",
                Species = "Gerbil",
                landSpeed = 1,
                requiredBedding = "wood shavings"
            };

            Mouse minnie = new Mouse()
            {
                Name = "Minnie",
                Color = "grey",
                Species = "Grey Mouse",
                landSpeed = 5,
                requiredBedding = "wood shavings"
            };

            TimberRattlesnake sly = new TimberRattlesnake()
            {
                Name = "Sly",
                Color = "brown",
                Species = "Timber Rattlesnake",
                landSpeed = 10,
            };

            Copperhead lucifer = new Copperhead
            {
                Name = "Lucifer",
                Color = "beige",
                Species = "Copperhead Snake",
                landSpeed = 10,
            };

            Terrapin mary = new Terrapin{
                 Name = "Mary",
                Color = "green",
                Species = "Terrapin",
                landSpeed = 1,
            };

            BettaFish alpha = new BettaFish{
                 Name = "Alpha",
                Color = "blue",
                Species = "Betta Fish",
                maximumDepth = 50,
            };

            FlierContainer flierStorage = new FlierContainer();
            DiggerContainer diggerStorage = new DiggerContainer();
            SwimmerContainer swimmerStorage = new SwimmerContainer();
            WalkerContainer walkerStorage = new WalkerContainer();

            flierStorage.Fliers.Add(bob);
            flierStorage.Fliers.Add(job);
            diggerStorage.Diggers.Add(joe);
            diggerStorage.Diggers.Add(jim);
            diggerStorage.Diggers.Add(jack);
            diggerStorage.Diggers.Add(minnie);
            swimmerStorage.Swimmers.Add(alpha);
            walkerStorage.Walkers.Add(sly);
            walkerStorage.Walkers.Add(lucifer);
            walkerStorage.Walkers.Add(mary);

            Console.WriteLine();



        }
    }
}
