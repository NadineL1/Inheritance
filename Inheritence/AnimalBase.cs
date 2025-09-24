using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Animal
    {
        // Base class method
        // static field to count each animal created
        public static int AnimalCount = 0;

        // fields/properties
        public string Color { get; set; }
        public string Food { get; set; }
        public bool hasWings { get; set; }
        public string SkinType { get; set; }
        public string Sound { get; set; }
        public string Pattern { get; set; }
        public string Movement { get; set; }

        // constructor for animal class
        public Animal()
        { 
            Color = "brown";
            Food = "food";
            hasWings = false;
            SkinType = "skin";
            Sound = "speaks";
            Pattern = "plain";
            Movement = "walks";
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

    }
}
