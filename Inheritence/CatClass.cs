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
            Console.WriteLine($"The cat is hunting for {Food}.");
            Random rand = new Random();
            int huntOutcome = rand.Next(0, 2); // generates a number between 0 and 1 to create a random hunt outcome
            if (huntOutcome == 0)
            {
                isHuntingSuccessful = false;
                Console.WriteLine("The hunt was unsuccessful, he will go to sleep hungry.");
            }
            else
            {
                isHuntingSuccessful = true;
                Console.WriteLine($"The hunt was successful! The {Food}had it coming!");
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
    // tiger subclass
    internal class Tiger : Cat
    {
        // tiger specific 
         public bool IsSolitary { get; set; }
         public Tiger()
       { 
            Color = "orange and black";
            Food = "deer meat";
            IsSolitary = true;
            Pattern = "striped";
            Sound = "ROARS";
        }
        //method specific to tiger class
        public void Swim()
        { 
            Console.WriteLine("The tiger is enjoying a swim.");
        }
    }
    internal class Panther : Cat
    {
        // property specific for panther, creativity level is done here.. 
        public int NumberOfLegs { get; set; }
        // constructor of panther class
        public Panther()
        {
            Color = "black as the night";
            Food = "wild hogs";
            Movement = "stalks";
            NumberOfLegs = 4;
        }
        // method overriding main method in Animal base
        override public void Eat()
        {
            Console.WriteLine($"The panther eats {Food} in the jungle.");
        }
    }
       
}
