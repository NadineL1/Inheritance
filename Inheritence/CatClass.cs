using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Cat : Animal
    {
        // constructor for catclass
        public Cat()
        {
            Color = "Black";
            Food = "fish";
            hasWings = false;
            SkinType = "Fur";
            Sound = "Meows";
            Pattern = "plain";
            Movement = "Climbs";
        }

    }
}
