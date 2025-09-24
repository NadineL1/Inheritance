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
            Color = "Brown";
            Food = "food";
            hasWings = false;
            SkinType = "Skin";
            Sound = "speaks";
            Pattern = "plain";
            Movement = "walks";
        }

        // methods for animal class
        public void Eat()
        {
            Console.WriteLine($"This animal eats {Food}");
        }
        public void Speak()
        {
            Console.WriteLine($"This animal {Sound}");
        }
        public void Move()
        {
            Console.WriteLine($"This animal {Movement}");
        }

    }
}
