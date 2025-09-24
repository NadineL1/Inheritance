using System;

namespace Inheritence
{
    internal class Horse : Animal
    {
        public Horse()
        {
            Color = "tan";
            Food = "hay";
            HasWings = false;
            SkinType = "fur";
            Sound = "neighs";
            Pattern = "plain";
            Movement = "gallops";
        }
    }
    internal class Donkey : Horse
    {
        public Donkey()
        { 
            Color = "gray";
            Sound = "brays";
            Movement = "strut";
        }
        public void Kick()
        {
            Console.WriteLine("Watch out! The donkey is kicking!!");
        }
    }
    internal class Zebra : Horse
    {
        public Zebra()
        { 
            Color = "black and white";
            Food = "grass";
            Pattern = "striped";
            Sound = "barks";
        }
        public override void Eat()
        { 
            Console.WriteLine($"This animal eats {Food} in the Savannah.");
        }
    }
}
