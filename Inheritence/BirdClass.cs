using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class BirdClass : Animal
    {
        public BirdClass()
        {
            Color = "Yellow";
            Food = "seeds";
            hasWings = true;
            SkinType = "Feathers";
            Sound = "chirps";
            Pattern = "varied";
            Movement = "flies";
        }

    }
}
