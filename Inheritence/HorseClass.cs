using System;

namespace Inheritence
{
    internal class Horse : Animal
    {
        // Horse specific property
        public bool IsUsedAsVechicle { get; set; }

        // horse constructor with gorse class default values
        public Horse()
        {
            Color = "tan";
            Food = "hay";
            HasWings = false;
            IsUsedAsVechicle = true;
            SkinType = "fur";
            Sound = "neighs";
            Pattern = "plain";
            Movement = "gallops";
        }
        // horse method
        public void JumpingCompetition()
        {
            Console.WriteLine("The horse has entered a jumping competition.");
        }
    }
    // Donkey subclass
    internal class Donkey : Horse
    {
        // donkey specific property
        public bool IsCharacterInShrek { get; set; }

        //donkey constructor w default values
        public Donkey()
        { 
            Color = "gray";
            IsCharacterInShrek = true;
            Movement = "strut";
            Sound = "brays";   
        }
        // donkey specific method
        public void Kick()
        {
            Console.WriteLine("Watch out! The donkey is kicking!!");
        }
    }
    // zebra subclass
    internal class Zebra : Horse
    {
        // zebra specific property
        public bool IsEndangered {  get; set; }
        // zebra constructor w default values
        public Zebra()
        { 
            Color = "black and white";
            Food = "grass";
            IsEndangered = true;
            Pattern = "striped";
            Sound = "barks";
        }
        // zebra method, override of method from animal base
        public override void Eat()
        { 
            Console.WriteLine($"This animal eats {Food} in the Savannah.");
        }
    }
}
