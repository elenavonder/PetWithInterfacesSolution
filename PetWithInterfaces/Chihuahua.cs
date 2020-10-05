using System;
using System.Collections.Generic;
using System.Text;

namespace PetWithInterfaces
{
    class Chihuahua : Dog, IBark
    {
        public Chihuahua (string name, string color, string barksound) : base (name, color, barksound)
        {

        }
        public Chihuahua () : base()
        {

        }
    }
}
