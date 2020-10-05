using System;
using System.Collections.Generic;
using System.Text;

namespace PetWithInterfaces
{
    class Collie : Dog
    {

        public void Bark()
        {
            Console.WriteLine($"The dog {Name}, has a {BarkSound} bark");
        }

        public Collie(string name, string color, string barksound)
        {
            this.Name = name;
            this.Color = color;
            this.BarkSound = barksound;
        }
        public Collie()
        {

        }
    }
}
