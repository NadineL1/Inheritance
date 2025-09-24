using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Horse : Animal
    {
        public Horse()
        {
            Color = "tan";
            Food = "hay";
            hasWings = false;
            SkinType = "fur";
            Sound = "neighs";
            Pattern = "plain";
            Movement = "gallops";
        }
    }
    internal class Zebra : Horse
    {

        public Zebra()
        { 
            Color = "black and white";
            Food = "grass";
            Pattern = "striped";
            Sound = "barks";
        }
        public override void Eat()
        { 
            Console.WriteLine($"This animal eats {Food} in the Savannah.");
        }
    }
}
