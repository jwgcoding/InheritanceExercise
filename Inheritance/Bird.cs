using System;
using System.Collections.Generic;
using System.Text;
// Create a class Bird
// give this class 4 members that are specific to Bird
// Set this class to inherit from your Animal Class

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Legs = 2;
            Eyes = 2;
            Mouth = 1;
            Body = 1;
        }
        public int Wings { get; set; }
        public int Beak { get; set; }
        public int Talons { get; set; }
        public int Feathers { get; set; }

    }
  
}
