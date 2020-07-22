using System;

namespace diggers_and_fliers
{
    public class Parakeet : Animal, IFlier
    {
        public int maximumDistance { get; set; }

        public void fly()
        {
            Console.WriteLine($"{Name} soars above the room, mocking your very presence as the bird craps all over your furniture.");
        }
    }
}