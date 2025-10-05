using System;

namespace Inheritence
{
    // subclass for birds, inheriting from animal
    internal class Bird : Animal
    {
        // new property for birdclass
        public string Dancing { get; set; }
        // constructor for birdclass with set defaut values
        public Bird()
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
        // methods for bird class
        public void Dance()
        {
            Console.WriteLine($"The birds are doing a {Dancing}.");
        }
        public void LayEgg()
        {
            Console.WriteLine("The bird has laid an egg!");
        }
    }
    // subclass Chicken
    internal class Chicken : Bird
    {
        // property for chicken class
        public bool CanBePeopleFood { get; set; }

        // constructor for chicken class with default values
        public Chicken()
        {
            CanBePeopleFood = true;
            Color = "white";
            Food = "grains";
            Movement = "walks and flaps its wings";
            Sound = "bocks";
        }
        // method for chicken class
        public void Peck()
        {
            Console.WriteLine($"The chicken pecks for {Food} the ground.");
        }
    }
    // subclass flamingo
    internal class Flamingo : Bird
    {
        // property for Flamingo
        public bool MateForLife {  get; set; }
        // constructor for flamingo w default values
        public Flamingo()
        {
            Color = "pink";
            Food = "crustasceans";
            MateForLife = true;
        }
        // method for flamingo subclass
        public void StandOnOneLeg()
        {
            Console.WriteLine("The flamingo is standing on one leg.");
        }
    }
    // subclass Owl
    internal class  Owl : Bird
    {
        // properties for subclass owl
        public bool IsNocturnal { get; set; }
        public bool SucessfulHunt { get; set; }
        // constructor for Owl w default values
        public Owl()
        {
            Color = "brown";
            Food = "mice";
            IsNocturnal = true;
            Movement = "turns its head 360 degrees.";
            Sound = "hoots";
        }
        // method for Owl, huntinh with random outcome
        public bool Hunting()
        {
            Console.WriteLine($"The owl is hunting for it's prey, its favorite food is {Food}.");
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
