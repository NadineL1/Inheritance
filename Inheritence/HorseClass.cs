using System;

namespace Inheritence
{
    internal class Horse : Animal
    {
        public bool IsUsedAsVechicle { get; set; }
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
        public void JumpingCompetition()
        {
            Console.WriteLine("The horse has entered a jumping competition.");
        }
    }
    internal class Donkey : Horse
    {
        public bool IsCharacterInShrek { get; set; }
        public Donkey()
        { 
            Color = "gray";
            IsCharacterInShrek = true;
            Movement = "strut";
            Sound = "brays";   
        }
        public void Kick()
        {
            Console.WriteLine("Watch out! The donkey is kicking!!");
        }
    }
    internal class Zebra : Horse
    {
        public bool IsEndangered {  get; set; }
        public Zebra()
        { 
            Color = "black and white";
            Food = "grass";
            IsEndangered = true;
            Pattern = "striped";
            Sound = "barks";
        }
        public override void Eat()
        { 
            Console.WriteLine($"This animal eats {Food} in the Savannah.");
        }
    }
}
