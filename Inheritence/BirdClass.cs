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
            Color = "yellow";
            Food = "seeds";
            hasWings = true;
            SkinType = "feathers";
            Sound = "chirps";
            Pattern = "varied";
            Movement = "flies";
        }

    }
    internal class Flamingo : BirdClass
    {
        public Flamingo()
        {
            Color = "pink";
            Food = "crustasceans";          
            Movement = "stands on one leg";
        }
    }
}
