using System;

namespace diggers_and_fliers
{
    public interface IDigger 
    {

        string requiredBedding {get; set;}
        void dig ();
    }
}