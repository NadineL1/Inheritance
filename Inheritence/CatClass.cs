using System;

namespace Inheritence
{
    internal class Cat : Animal
    {
        bool isHuntingSuccessful { get; set; }
        // constructor for catclass
        public Cat()
        {
            Color = "black";
            Food = "fish";
            HasWings = false;
            SkinType = "thick fur";
            Sound = "meows";
            Pattern = "plain";
            Movement = "climbs";
        }
        // methods specific for the cat class
        public void Strech()
        {
            Console.WriteLine("The cat streches.");
        }
        public bool Hunt()
        {
            Console.WriteLine($"The cat is hunting for {Food}");
            Random rand = new Random();
            int huntOutcome = rand.Next(0, 2); // generates a number between 0 and 1
            if (huntOutcome == 0)
            {
                isHuntingSuccessful = false;
                Console.WriteLine("The hunt was unsuccessful.");
            }
            else
            {
                isHuntingSuccessful = true;
                Console.WriteLine("The hunt was successful!");
            }
            return isHuntingSuccessful;
        }
    }
    // classes derived from cat
    internal class Lion : Cat
    {
        public bool HasMane { get; set; }
        public Lion()
        {
            Color = "golden";
            Movement = "prowls";
            Food = "meat";
            Sound = "roars";
            if (Gender == "female")
            {
                HasMane = false;
            }
            else
            {
                HasMane = true;
            }
        }
        // method specific to lion class
        public void Territory()
        {
            Console.WriteLine("The lions are protecting their territory!");
        }
    }
    internal class Tiger : Cat
    {
         public bool IsSolitary { get; set; }
         public Tiger()
       { 
            Color = "orange and black";
            Food = "deer meat";
            IsSolitary = true;
            Pattern = "striped";
        }
        //method specific to tiger class
        public void Swim()
        { 
            Console.WriteLine("The tiger is enjoying a swim.");
        }
    }
    internal class Panther : Cat
    {
        public int NumberOfLegs;
        public Panther()
        {
            Color = "black as the night";
            Food = "wild hogs";
            Movement = "stalks";
            NumberOfLegs = 4;
        }
        override public void Eat()
        {
            Console.WriteLine($"The panther eats {Food} in the jungle.");
        }
    }
       
}
