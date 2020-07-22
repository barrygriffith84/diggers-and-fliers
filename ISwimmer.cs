using System;

namespace diggers_and_fliers
{
    public interface ISwimmer 
    {
        int maximumDepth {get; set;}
        void swim ();
    }
}