using System;

namespace Inheritence
{
    internal class BirdClass : Animal
    {
        public string Dancing { get; set; }
        public BirdClass()
        {
            Color = "yellow";
            Dancing = "mating dance";
            Food = "seeds";
            HasWings = true;
            Movement = "flies";
            Pattern = "varied";
            SkinType = "feathers";
            Sound = "chirps";
        }
        public void Dance()
        {
            Console.WriteLine($"The birds are doing a {Dancing}.");
        }
        public void LayEgg()
        {
            Console.WriteLine("The bird has laid an egg!");
        }
    }
    internal class Chicken : BirdClass
    {
        public bool CanBePeopleFood { get; set; }
        public Chicken()
        {
            CanBePeopleFood = true;
            Color = "white";
            Food = "grains";
            Movement = "walks and flaps its wings";
        }
        public void Peck()
        {
            Console.WriteLine($"The chicken pecks for {Food} the ground.");
        }
    }
    internal class Flamingo : BirdClass
    {
        public bool MateForLife {  get; set; }
        public Flamingo()
        {
            Color = "pink";
            Food = "crustasceans";
            MateForLife = true;
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
            Movement = "turns its head 360 degrees.";
            Sound = "hoots";
        }
        public void Hunting()
        {
            Console.WriteLine("The owl is hunting for it's prey.");
        }
    }
}
