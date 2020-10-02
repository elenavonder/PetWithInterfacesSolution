using System;
using System.Collections.Generic;
using System.Text;

namespace PetWithInterfaces
{
    class Collie : IBark
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string BarkSound { get; set; }

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
