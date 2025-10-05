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
        public bool SucessfulHunt { get; set; }
        public Owl()
        {
            Color = "brown";
            Food = "mice";
            IsNocturnal = true;
            Movement = "turns its head 360 degrees.";
            Sound = "hoots";
        }
        public bool Hunting()
        {
            Console.WriteLine($"The owl is hunting for it's prey, a {Food}.");
            Random rand = new Random();
            int huntOutcome = rand.Next(0, 2); // generates a number between 0 and 1 to create a random hunt outcome
            if (huntOutcome == 0)
            {
                SucessfulHunt = false;
                Console.WriteLine($"The hunt was unsuccessful, the {GetType().Name} got its {Food}");
            }
            else
            {
                SucessfulHunt = true;
                Console.WriteLine("The hunt was successful!");
            }
            return SucessfulHunt;
        }
    }
}
