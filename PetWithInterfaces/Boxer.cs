using System;
using System.Collections.Generic;
using System.Text;

namespace PetWithInterfaces
{
    class Boxer : Dog, IBark
    {

        public Boxer(string name, string color, string barksound) : base (name, color, barksound)
        {

        }

        public Boxer() : base ()
        {

        }

    }
}
