using System;

namespace Inheritence
{
    internal class BirdClass : Animal
    {
        public BirdClass()
        {
            Color = "yellow";
            Food = "seeds";
            Gender = " ";
            HasWings = true;
            Movement = "flies";
            Pattern = "varied";
            SkinType = "feathers";
            Sound = "chirps";
        }
        public void LayEgg()
        {
            Console.WriteLine("The bird has laid an egg!");
        }
    }
    internal class Chicken : BirdClass
    {
        public Chicken()
        {
            Color = "white";
            Food = "grains";
            Movement = "walks and flaps its wings";
        }
        public void Peck()
        {
            Console.WriteLine("The chicken pecks the ground.");
        }
    }
    internal class Flamingo : BirdClass
    {
        public Flamingo()
        {
            Color = "pink";
            Food = "crustasceans";          
        }
        public void StandOnOneLeg()
        {
            Console.WriteLine("The flamingo is standing on one leg.");
        }
    }
    internal class  Owl : BirdClass
    {
        public bool IsNocturnal { get; set; }
        public Owl()
        {
            Color = "brown";
            Food = "mice";
            IsNocturnal = true;
            Sound = "hoots";
        }
        public void Hunting()
        {
            Console.WriteLine("The owl is hunting for it's prey.");
        }
    }
}
