using System;
using System.Collections.Generic;
using System.Text;
// Create a class Reptile
// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class


namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
            {
            Legs = 4;
            Eyes = 2;
            Mouth = 1;
            Body = 1;
            }
    public int Claws { get; set; }
        public int Scales { get; set; }
        public bool HasTail { get; set; }

        public bool Markings { get; set; }
    }

}
