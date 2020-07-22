using System;

namespace diggers_and_fliers
{
    public interface IFlier 
    {
        int maximumDistance {get; set;}
        void fly ();
    }
}