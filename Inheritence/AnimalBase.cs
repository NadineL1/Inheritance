using System;


namespace Inheritence
{
    internal class Animal 
    {
        // Base class method
        // static field to count each animal created
        public static int AnimalCount = 0;

        // fields/properties for animal class
        public string Color { get; set; }
        public string Food { get; set; }
        public string Gender { get; set; }
        public bool HasWings { get; set; }
        public string Movement { get; set; }
        public string Pattern { get; set; }
        public string SkinType { get; set; }
        public string Sound { get; set; }

        // constructor for animal class
        public Animal()
        { 
            Color = "brown";
            Food = "food";
            Gender = "Male";
            HasWings = false;
            Movement = "walks";
            Pattern = "plain";
            SkinType = "skin";
            Sound = "speaks";
            
            AnimalCount++;
        }

        // methods for animal class
        public virtual void Eat()
        {
            Console.WriteLine($"This animal eats {Food}");
        }
        public void MakeSound()
        {
            Console.WriteLine($"This animal {Sound}");
        }
        public void Move()
        {
            Console.WriteLine($"This animal {Movement}");
        }
        public void ProCreate()
        {
            Console.WriteLine("A new life has been created! A lovely {} has been born!");
        }
    }
}
