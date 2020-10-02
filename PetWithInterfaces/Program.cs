using System;

namespace PetWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var col1 = new Collie("Rudy", "Black", "Medium");
            var box1 = new Boxer("Nikita", "Brown", "Low-Pitch");
            var chi1 = new Chihuahua("Julio", "Yellow", "High-Pitch");
            col1.Bark();
            box1.Bark();
            chi1.Bark();
            var Pets = new IBark()
            {

            }
        }
    }
}
