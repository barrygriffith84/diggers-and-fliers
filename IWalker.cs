using System;

namespace diggers_and_fliers
{
    public interface IWalker
    {
        int landSpeed {get; set;}
        void walk ();
    }
}